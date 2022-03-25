using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB.Architecture;
using System.ComponentModel;
using IIB1_UE1_Gruppe12_Klassen;
using IIB1_UE1_Gruppe12_GUI;
using System.IO;
using RevitRoom = Autodesk.Revit.DB.Architecture.Room;
using System.Linq;
using Autodesk.Revit.DB.Structure;
using System.Collections.Generic;
using ClassRaum = IIB1_UE1_Gruppe12_Klassen.Raum;
using ClassFeuerloescher = IIB1_UE1_Gruppe12_Klassen.Feuerloescher;
using PlaceData = IIB1_UE1_Gruppe12_GUI.Feuerlöscher_verwalten.PlaceData;
using System.Windows.Forms;

namespace IIB1_UE2_Gruppe12_RevitAddin
{
    [Transaction(TransactionMode.Manual)]
    class IIB1_Gruppe12_RevitAddin : IExternalCommand
    {
        // ModelessForm instance
        public static MAINGUI _maingui;
        private static Document _doc;
        private static UIDocument _uidoc;
        private static ExternalCommandData _ecd;

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                _ecd = commandData;
                List<Gebaeude> gebaeudes = new List<Gebaeude>();
                UIApplication uiApp = commandData.Application;
                _uidoc = uiApp.ActiveUIDocument;
                _doc = IIB1_Gruppe12_Util.Doc = _uidoc.Document;

                gebaeudes.Add(IIB1_Gruppe12_Util.parseBuilding());

                if (_maingui != null && _maingui.Visible)
                {
                    _maingui.Close();
                    _maingui = null;
                }

                ShowForm(gebaeudes);
                return Autodesk.Revit.UI.Result.Succeeded;
            }
            catch (Exception e)
            {
                TaskDialog.Show("Revit", e.ToString());
                return Result.Failed;
            }
        }

        public void ShowForm(List<Gebaeude> gebaeudes)
        {
            #region eröffnen MAINGUI
            if (_maingui == null || _maingui.IsDisposed)
            {
                RoomInfoUpdater updateHandlerR = new RoomInfoUpdater();
                FeuerloescherInfoUpdater updateHandlerF = new FeuerloescherInfoUpdater();
                ExternalEvent updateEventR = ExternalEvent.Create(updateHandlerR);
                ExternalEvent updateEventF = ExternalEvent.Create(updateHandlerF);
                FeuerloescherPlacer feuerloescherPlacer = new FeuerloescherPlacer();
                ExternalEvent placeEvent = ExternalEvent.Create(feuerloescherPlacer);

                _maingui = new MAINGUI(updateEventR, updateEventF, placeEvent, gebaeudes);
                _maingui.Show();
            }
            #endregion
        }

        #region Event Handler
        public class RoomInfoUpdater : IExternalEventHandler
        {
            #region Event Handler für Raum verändern
            public static readonly string typeofuse = "Nutzungsgruppe DIN 277-2";

            public void Execute(UIApplication app)
            {
                update(_maingui.ra);
            }

            private static void update(ClassRaum _clr)
            {
                if (_clr != null)
                {
                    try
                    {
                        bool worked;
                        if (_clr.Identity != null)
                        {
                            RevitRoom room = (RevitRoom)_doc.GetElement(_clr.Identity);
                            using (Transaction trans = new Transaction(_doc))
                            {
                                if (trans.Start("Change Room Parameters") == TransactionStatus.Started)
                                {
                                    room.Name = _clr.Raum_bezeichnung;

                                    worked = room.GetParameters("Brandlast").First().Set(_clr.Brandlast);
                                    worked &= room.GetParameters("LE").First().Set(_clr.LE);
                                    worked &= room.GetParameters(typeofuse).First().Set(_clr.Typ);

                                    trans.Commit();
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        TaskDialog.Show("RoomInfoUpdater", e.Message);
                    }
                }
                else
                {
                    TaskDialog.Show("RoomInfoUpdater", "Please select a Room!");
                }
            }

            public string GetName()
            {
                return "Update Room Information";
            }
            #endregion
        }

        public class FeuerloescherInfoUpdater : IExternalEventHandler
        {
            #region Event Handler für Feuerlöscher verändern
            public void Execute(UIApplication app)
            {
                update(_maingui.Feu._fl);
            }

            private static void update(ClassFeuerloescher _fl)
            {
                if (_fl != null)
                {
                    try
                    {
                        bool worked;
                        if (_fl.Identity != null)
                        {
                            FamilyInstance fi = (FamilyInstance)_doc.GetElement(_fl.Identity);
                            using (Transaction trans = new Transaction(_doc))
                            {
                                if (trans.Start("Change Feuerlöscher Parameters") == TransactionStatus.Started)
                                {
                                    fi.Name = _fl.Name;
                                    worked = fi.GetParameters("Kapazität").First().Set(_fl.Kapazitaet);
                                    worked &= fi.GetParameters("Preis").First().Set(_fl.Preis);
                                    worked &= fi.GetParameters("Brandklasse").First().Set(_fl.BrandklasseS);

                                    trans.Commit();
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        TaskDialog.Show("FeuerlöscherInfoUpdater", e.Message);
                    }
                }

                else
                {
                    TaskDialog.Show("FeuerlöscherInfoUpdater", "Please select a Feuerlöscher!");
                }
            }
            public string GetName()
            {
                return "Update Feuerlöscher Information";
            }
            #endregion
        }



        public class FeuerloescherPlacer : IExternalEventHandler
        {
            #region Event Handler für Feuerlöscherplacer
            public void Execute(UIApplication app)
            {
                placeFeu(_maingui.Feu._cpr);
            }

            private void placeFeu(PlaceData cpr)
            {
                XYZ locR = _ecd.Application.ActiveUIDocument.Selection.PickPoint("Pick a point to place Feuerlöscher.");
                RevitRoom rr = _doc.GetElement(cpr.raum.Identity) as RevitRoom;
                RevitRoom roomAtPoint = _doc.GetRoomAtPoint(locR);

                if (roomAtPoint.UniqueId != rr.UniqueId)
                {
                    TaskDialog.Show("ERROR", "Punkt liegt nicht in ausgewählten Raum.");
                    return;
                }

                try
                {
                    if (null != locR)
                    {
                        using (Transaction trans = new Transaction(_doc))
                        {
                            if (trans.Start("PlaceFamily") == TransactionStatus.Started)
                            {

                                FamilyInstance fi = _doc.Create.NewFamilyInstance(locR,
                                    GetFamilySymbolByName(BuiltInCategory.OST_SpecialityEquipment, cpr.feuerloescher.Name)
                                    , StructuralType.NonStructural);
                                cpr.feuerloescher.Identity = fi.UniqueId;
                                cpr.feuerloescher.ID = fi.Id.ToString();
                                _maingui.Feu.ra.feuerloeschers.Add(cpr.feuerloescher);
                                trans.Commit();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    TaskDialog.Show("FeuerlöscherPlatzierer", e.Message);
                }
            }
            private static FamilySymbol GetFamilySymbolByName(BuiltInCategory bic, string name)
            {
                return new FilteredElementCollector(_doc).OfCategory(bic).OfClass(typeof(FamilySymbol))
                    .FirstOrDefault<Element>(e => e.Name.Equals(name)) as FamilySymbol;
            }

            public string GetName()
            {
                return "FeuerlöscherPlatzierer";
            }
            #endregion
        }

    }
}

#endregion