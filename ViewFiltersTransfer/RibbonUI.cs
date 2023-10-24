/* IMPORT LIBRARIES */
using System;
using System.Collections.Generic;
// Libraries for Revit
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using System.Linq;

namespace ViewFiltersTransfer
{
    [Transaction(TransactionMode.Manual)]
    public class RibbonUI : IExternalApplication
    {
        /* ATTRIBUTES */
        //private String projectFolderPath = System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;
        private String projectFolderPath = "c:\\Users\\galbieri\\OneDrive - Buro Happold\\Structures\\10_Computational\\HOI\\Revit API Plugins\\ViewFiltersTransfer\\ViewFiltersTransfer\\";
        private String imagesFolderPath, textFolderPath;
        private RibbonPanel ribbonPanel;


        /* CONSTRUCTOR */
        //Default
        public RibbonUI() { }


        /* METHODS */

        // OnStartup - Implemented from IExternalApplication Interface
        public Result OnStartup(UIControlledApplication application)
        {
            try
            {
                //1. Get Ribbon Panel "View Filters"
                RibbonPanel ribbonPanel = application.GetRibbonPanels("BH Plugins").
                                          Find(rbPanel => rbPanel.Name == "View Filters");
                               
                //2. Buildup Inputs for RibbonItemFactory
                imagesFolderPath = this.projectFolderPath + "Images\\";
                textFolderPath = this.projectFolderPath + "Text Files\\";
                String imagePath = imagesFolderPath + "AppLogo64x64.png";
                String largeImagePath = imagesFolderPath + "AppLogo96x96.png";
                String toolTipImagePath = imagesFolderPath + "AppLogo.png";
                String toolTipText = "View Filters Transfer";
                String longDescription = System.IO.File.ReadAllText(textFolderPath + "AppLongDescription.txt");
                String assemblyFullPath = projectFolderPath + "bin\\Debug\\ViewFiltersTransfer.dll";
                String className = "ViewFiltersTransfer.Command";

                //3. Create RibbonItem (PushButton)
                RibbonItemFactory.getInstance().create(ribbonPanel, RibbonItemType.PushButton, "View Filters\n Transfer", imagePath,
                                                       largeImagePath, toolTipImagePath, toolTipText, longDescription, assemblyFullPath,
                                                       className);
                return Result.Succeeded;
            }
            catch (Exception e)
            {
                return Result.Failed;
            }
        }



        // OnShutdown - Implemented from IExternalApplication Interface
        public Result OnShutdown(UIControlledApplication application)
        {
            try
            {
                return Result.Succeeded;
            }
            catch (Exception e)
            {
                return Result.Failed;
            }
        }
    }


}
