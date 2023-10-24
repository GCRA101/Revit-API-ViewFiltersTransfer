/* IMPORT LIBRARIES */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Libraries for UI Buttons/Panels
using System.Reflection;
using System.Xaml;
// Libraries for Revit
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
// Libraries for ETABS
using ETABSv1;
// Other Libraries
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using Autodesk.Revit.Creation;
using System.Security.Cryptography;
using View = Autodesk.Revit.DB.View;

namespace ViewFiltersTransfer
{
    /* COMMAND CLASS ************************************************************ */

    [Transaction(TransactionMode.Manual)] 
    public class Command : IExternalCommand
    {
        /*ATTRIBUTES*/
        private Autodesk.Revit.UI.UIApplication uiApp;
        private Autodesk.Revit.UI.UIDocument uiDoc;
        private Autodesk.Revit.DB.Document doc;

        /*IMPLEMENTED METHODS*/

        // Execute Method from IExternalCommand Interface
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                //1. CREATE DB AND UI DOCUMENT OBJECTS
                //Assignment
                this.uiDoc = commandData.Application.ActiveUIDocument;
                this.doc = uiDoc.Document;
                //2. CALL COMMAND FUNCTION
                transferViewFilters();
                return Result.Succeeded;
            }
            catch (Exception e)
            {
                return Result.Failed;
            }
        }


        /* METHODS */

        //transferViewFilters()
        private void transferViewFilters()
        {
            /*1. GET THE ACTIVE VIEW */
            View activeView = doc.ActiveView;

            /*2. GET ALL THE FILTERS' NAMES AND COLORS ASSIGNED TO THE ACTIVE VIEW */
            Dictionary<String, Autodesk.Revit.DB.Color> filterColorsDict = activeView.GetFilters().
                            ToDictionary(filterId => ((ParameterFilterElement)doc.GetElement(filterId)).Name.ToString(),
                                         filterId=>activeView.GetFilterOverrides(filterId).SurfaceBackgroundPatternColor);



        }

    }
}
