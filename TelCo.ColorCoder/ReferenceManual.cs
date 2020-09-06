using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
    class ReferenceManual
    {
        internal void PrintReferenceManual()
        {
            Console.WriteLine("REFERENCE MANUAL");
            int minorSize = ListOfColors.MinorMapColor.Length;
            int majorSize = ListOfColors.MajorMapColor.Length;
            int totalSize = minorSize * majorSize;
            for(int i=1;i<=totalSize;i++)
            {
                ColorPair pair=ColorFromPairNumber.GetColorFromPairNumber(i);
                Console.WriteLine("Pair No : " + i+" "+ pair.ToString());
                
            }
        }
    }
}
