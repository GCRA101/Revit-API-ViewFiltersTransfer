# Revit-API-ViewFiltersTransfer

## Description

Revit API IExternalApplication plugin executable via PushButton in the Revit Ribbon Tab Panel "BH Plugins".
The application carries out the following tasks:
* Collects the View Filters currently assigned to the Revit Active View together with the information regarding their names and assigned color.
* Creates Groups in the ETABS model currently open named after the corresponding View Filters and assigned with the same colors
* Assigns all the ETABS frame objects to the corresponding Group based on the corresponding section type name.

The automated creation of Groups in ETABS mirroring the View Filters defined in Revit allows to display quickly and visually the differences between frame section assignments between the Revit and the ETABS model.

## UML Classes Diagram

![UML Diagram](https://github.com/GCRA101/Revit-API-ViewFiltersTransfer/blob/main/UML%20Diagrams/Classes%20Diagram.png?raw=true)

## Install

To install the plugin, first make sure to have no Revit instance running on the computer and follow the steps below:
1. Build the code
2. Copy and paste the .addin file in the folder c:\Users\UserName\AppData\Roaming\Autodesk\Revit\Addins\Version\
3. Create the folder ViewFiltersTransfer\ in the folder at point 2. and place in it a copy of the assembly file (ViewFiltersTransfer.dll)
4. Unblock both the .addin and the .dll file (right click on it -> Properties -> Check the checkbox "Unblock")
5. Run Revit
6. Find the plugin button in the BH Plugins Ribbon Tab


