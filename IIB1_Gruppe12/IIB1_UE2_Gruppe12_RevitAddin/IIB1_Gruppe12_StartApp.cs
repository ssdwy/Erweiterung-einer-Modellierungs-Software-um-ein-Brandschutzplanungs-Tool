using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIB1_UE2_Gruppe12_RevitAddin
{
    public class IIB1_Gruppe12_StartApp : IExternalApplication
    {
        static string path = typeof(IIB1_Gruppe12_StartApp).Assembly.Location;

        public Result OnStartup(UIControlledApplication application)
        {
            //Create a custom ribbon tab
            String tabName = "IIB1_Gruppe12";
            application.CreateRibbonTab(tabName);

            //Create a ribbon panel
            RibbonPanel gruppe12_Panel = application.CreateRibbonPanel(tabName, "IIB1_Gruppe_12");

            //Create two push buttons
            PushButton button1 = (PushButton)gruppe12_Panel.AddItem(new PushButtonData("Button1", "Feuerlöscher Manager", path, typeof(IIB1_Gruppe12_RevitAddin).FullName));
            button1.ToolTip = "Feuerlöscher-Manager-Application eröffnen";

            return Result.Succeeded;
        }



        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
