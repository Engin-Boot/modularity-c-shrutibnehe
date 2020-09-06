using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ListOfColors
    {
        private static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        private static Color[] colorMapMinor;
        /// <summary>
        /// data type defined to hold the two colors of clor pair
        /// </summary>

        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static ListOfColors()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
        internal static Color[] MajorMapColor
        {
            get
            {
                return colorMapMajor;
            }
        }
        internal static Color[] MinorMapColor
        {
            get
            {
                return colorMapMinor;
            }
        }
    }
}
