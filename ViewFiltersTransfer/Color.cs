using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewFiltersTransfer
{
    public class Color : ColorInterface
    {
        /* ATTRIBUTES */
        private Byte red,green, blue;
        private Byte[] RGB;
        private int etabsIntValue;

        /* CONSTRUCTOR */
        //Overloaded
        public Color(Byte red, Byte green, Byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            Byte[] rGB = {red, green, blue};
            this.RGB = rGB;
            this.etabsIntValue = getEtabsIntValue();
        }

        /* METHODS */

        //Methods from implemented Interfaces
        public byte getRed() { return this.red;}
        public byte getGreen() { return this.green;}
        public byte getBlue(){ return this.blue;}
        public byte[] getRGB() { return this.RGB;}
        public int getEtabsIntValue()
        {
            return (int)this.getRed() + (int)this.getGreen() * 256 + (int)this.getBlue() * 256 * 256;
        }
            

    }
}
