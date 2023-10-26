using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;

namespace ViewFiltersTransfer
{
    public class RevitColorAdapter : ColorInterface
    {
        /* ATTRIBUTES */
        Autodesk.Revit.DB.Color revitColor;

        /* CONSTRUCTOR */
        // Overloaded
        public RevitColorAdapter(Autodesk.Revit.DB.Color revitColor)
        {
            this.revitColor=revitColor;
        }

        /* METHODS */

        public byte getRed() { return this.revitColor.Red; }
        public byte getGreen() { return this.revitColor.Green; }
        public byte getBlue() { return this.revitColor.Blue; }
        public byte[] getRGB() {
            byte[] rgb = { this.revitColor.Red, this.revitColor.Green, this.revitColor.Blue };
            return rgb;}
        public int getEtabsIntValue()
        {
            return (int)this.getRed() + (int)this.getGreen() * 256 + (int)this.getBlue() * 256 * 256;
        }
    }
}
