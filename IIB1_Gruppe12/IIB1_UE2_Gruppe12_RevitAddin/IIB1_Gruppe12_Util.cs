using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using ClassStockwerk = IIB1_UE1_Gruppe12_Klassen.Stockwerk;
using ClassRaum = IIB1_UE1_Gruppe12_Klassen.Raum;
using ClassFeuerloescher = IIB1_UE1_Gruppe12_Klassen.Feuerloescher;
using IIB1_UE1_Gruppe12_Klassen;
using Autodesk.Revit.UI;
using System.ComponentModel;
using RevitRoom = Autodesk.Revit.DB.Architecture.Room;
namespace IIB1_UE2_Gruppe12_RevitAddin
{
    class IIB1_Gruppe12_Util
    {
        private static Document _doc = null;

        public static Document Doc
        {
            set
            {
                _doc = value;
            }
        }

        #region bekommen die Building
        public static Gebaeude parseBuilding()
        {
            ProjectInfo pi = _doc.ProjectInformation;
            Gebaeude building = new Gebaeude(pi.Name, new List<ClassStockwerk>());
            building.Stockwerkliste = getStockwerke();
            return building;
        }
        #endregion

        #region bekommen die Geschosse in der Building
        public static List<ClassStockwerk> getStockwerke()
        {
            FilteredElementCollector collector = new FilteredElementCollector(_doc);
            ICollection<Element> stockwerke = collector.OfClass(typeof(Level)).ToElements();
            List<ClassStockwerk> cfls = new List<ClassStockwerk>();
            foreach (Element fl in stockwerke)
            {
                ClassStockwerk cfl = parseStockwerk((Level)fl);
                cfl.Raumliste = getRooms((Level)fl);

                if (cfl.Raumliste.Count != 0)
                {
                    cfls.Add(cfl);
                }
            }
            return cfls;
        }

        public static ClassStockwerk parseStockwerk(Level floor)
        {
            ClassStockwerk cfl = new ClassStockwerk(floor.Name, new List<ClassRaum>());
            cfl.Identity = floor.Id.ToString();
            string[] fl = new string[2];
            fl = cfl.Bezeichnung.Split(' ');
            cfl.Ebene = fl[1];
            return cfl;
        }
        #endregion

        #region bekommen die Räume im Geschoss
        public static List<ClassRaum> getRooms(Level floor)
        {

            IEnumerable<Element> Roomsbylevel_filcol = new FilteredElementCollector(_doc) //search only in this level
            .OfClass(typeof(SpatialElement)).Where(room => room.GetType() == typeof(Autodesk.Revit.DB.Architecture.Room))  //get all rooms
            .Cast<SpatialElement>()  //cast results to SpatialElements
            .Where(o => o.LevelId == floor.Id); //search by the above mentioned Level

            List<ClassRaum> crooms = new List<ClassRaum>();
            foreach (SpatialElement r in Roomsbylevel_filcol)
            {
                ClassRaum croom = parseRoom((RevitRoom)r);

                if (croom != null)
                {
                    crooms.Add(croom);
                }
            }
            return crooms;
        }

        public static ClassRaum parseRoom(RevitRoom room)
        {
            Raum raum = new ClassRaum();
            raum.Identity = room.UniqueId;
            raum.Id = room.Number;
            raum.Raum_bezeichnung = room.GetParameters("Name")[0].AsString();
            raum.Flaeche = squarefeetToMeter(room.Area);
            raum.Typ = room.GetParameters("Nutzungsgruppe DIN 277-2")[0].AsString();
            raum.Brandlast = room.GetParameters("Brandlast")[0].AsDouble();
            raum.LE = room.GetParameters("LE")[0].AsInteger();

            List<Element> feuerloeschers1 = GetFeuerloescher(room);
            List<ClassFeuerloescher> feuerloeschers2 = new List<ClassFeuerloescher>();

            foreach (Element e in feuerloeschers1)
            {
                ClassFeuerloescher feuerloescher = new ClassFeuerloescher();
                feuerloescher.Identity = e.UniqueId;
                feuerloescher.ID = e.Id.ToString();
                feuerloescher.Name = e.Name;
                feuerloescher.Kapazitaet = e.GetParameters("Kapazität")[0].AsDouble();
                feuerloescher.Preis = e.GetParameters("Preis")[0].AsDouble();
                feuerloescher.BrandklasseS = e.GetParameters("Brandklasse")[0].AsString();
                if (feuerloescher.BrandklasseS.Contains(','))
                {
                    feuerloescher.BrandklasseL = feuerloescher.StringtoList(feuerloescher.BrandklasseS);
                }


                feuerloeschers2.Add(feuerloescher);
                
                raum.feuerloeschers = feuerloeschers2;
            }

            return raum;
        }

        public static double squarefeetToMeter(double squarefeet)
        {
            double quadratmeter = (squarefeet / 10.7639);
            return Math.Round(quadratmeter, 2);
        }
        #endregion

        #region Methode für Feuerlöscherbekommen
        public static List<Element> GetFeuerloescher(RevitRoom room)
        {
            BoundingBoxXYZ bb = room.get_BoundingBox(null);

            Outline outline = new Outline(bb.Min, bb.Max);

            BoundingBoxIntersectsFilter filter
              = new BoundingBoxIntersectsFilter(outline);

            Document doc = room.Document;

            BuiltInCategory[] bics = new BuiltInCategory[] {
                BuiltInCategory.OST_SpecialityEquipment
            };

            LogicalOrFilter categoryFilter
                = new LogicalOrFilter(bics
                .Select<BuiltInCategory, ElementFilter>(
                bic => new ElementCategoryFilter(bic))
                .ToList<ElementFilter>());

            FilteredElementCollector collector
              = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .WhereElementIsViewIndependent()
                .WherePasses(filter)
                .WherePasses(categoryFilter)
                .OfClass(typeof(FamilyInstance));


            int roomid = room.Id.IntegerValue;

            List<Element> a = new List<Element>();

            foreach (FamilyInstance fi in collector)
            {
                if (null != fi.Room
                    && fi.Room.Id.IntegerValue.Equals(roomid)
                    && fi.Name.ToLower().Contains("feuerlöscher"))
                {
                    a.Add(fi);
                }
            }
            return a;
        }
        #endregion
    }
}
