using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public class Roman_Numerals_Encoder
    {
        public static string Solution(int n)
        {
            string romanNumeral = "";

            if (n >= 1000)
            {
                for (int i = 0; i < n / 1000; i++)
                {
                    romanNumeral += "M";
                }
                n -= n / 1000 * 1000;
            }
            if (n >= 500)
            {
                romanNumeral += "D";
                n -= 500;                
            }
            for (int i = 0; i < n / 100; i++)
            {
                romanNumeral += "C";
            }
            n -= n / 100 * 100;
            if (n >= 50)
            {
                romanNumeral += "L";
                n -= 50;                
            }
            for (int i = 0; i < n / 10; i++)
            {
                romanNumeral += "X";
            }
            n -= n / 10 * 10;
            if (n >= 5)
            {
                romanNumeral += "V";
                n -= 5;                
            }
            for (int i = 0; i < n; i++)
            {
                romanNumeral += "I";
            }

            return romanNumeral;
        }
    }
}
