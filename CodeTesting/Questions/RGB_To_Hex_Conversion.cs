using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public class RGB_To_Hex_Conversion
    {
        public static string Rgb(int r, int g, int b)
        {
            if (r > 255)
                r = 255;

            if (g > 255)
                g = 255;

            if (b > 255)
                b = 255;

            if (r < 0)
                r = 0;

            if (g < 0)
                g = 0;

            if (b < 0)
                b = 0;

            return string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }

        public static string Rgb_Answer(int r, int g, int b)
        {
            //Max returns larger of the 2
            r = Math.Max(Math.Min(255, r), 0);
            g = Math.Max(Math.Min(255, g), 0);
            b = Math.Max(Math.Min(255, b), 0);
            return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }
    }
}
