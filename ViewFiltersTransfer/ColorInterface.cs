﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewFiltersTransfer
{
    public interface ColorInterface
    {
        Byte getRed();
        Byte getGreen();
        Byte getBlue();
        Byte[] getRGB();
        int getEtabsIntValue();

    }
}
