using System;
using System.Collections.Generic;
using System.Text;

namespace InfoRepro
{
    public static class ZoomExtension
    {
        public static double Clamp(this double self, double seg, double max) 
        { 
            return Math.Min(max, Math.Max(self, seg)); 
        }
    }

}


