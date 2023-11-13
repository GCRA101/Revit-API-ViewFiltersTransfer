using ETABSv1;
using CSiAPIv1;
using System.Collections.Generic;
using Autodesk.Revit.DB;
using System.Linq;
using System;

namespace ViewFiltersTransfer
{
    public class PushGroups : PushBehaviour
    {
        /* ATTRIBUTES */
        private Dictionary<string, ColorInterface> groups;

        /* CONSTRUCTORS */
        // Default
        public PushGroups(ETABSv1.cSapModel etabsModel) :base(etabsModel){}
        // Overloaded
        public PushGroups(ETABSv1.cSapModel etabsModel, Dictionary<string,ColorInterface> groups) : base(etabsModel)
        {
            this.groups = groups;
        }

        /* METHODS */
        
        public void setGroups(Dictionary<string, ColorInterface> groups)
        {
            this.groups = groups;
        }

        public void push()
        {
            // Delete Groups already existing in the ETABS Model
            this.groups.ToList().ForEach(kvpair => this.etabsModel.GroupDef.Delete(kvpair.Key));
            // Create Groups
            this.groups.ToList().ForEach(kvpair => this.etabsModel.GroupDef.SetGroup_1(kvpair.Key,kvpair.Value.getEtabsIntValue()));
        }

    }
}