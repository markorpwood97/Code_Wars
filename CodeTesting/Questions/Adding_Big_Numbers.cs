using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars.Questions
{
    public class Adding_Big_Numbers
    {
        public static string Add(string a, string b)
        {
            string totalsum = (double.Parse(a) + double.Parse(b)).ToString();
            if (double.Parse(totalsum) < 10000000000)
                return (double.Parse(a) + double.Parse(b)).ToString();
            else
            {
                string output = "";
                char[] aChar = a.ToCharArray();
                char[] bChar = b.ToCharArray();
                char first;
                char second;
                int highestCount;
                bool carryOver = false;
                if (aChar.Count() > bChar.Count()) highestCount = aChar.Count(); else highestCount = bChar.Count();

                for (int i = highestCount - 1; i >= 0; i--)
                {
                    try { first = aChar[i]; } catch { first = '0'; };
                    try { second = bChar[i]; } catch { second = '0'; };

                    int sum = int.Parse(first.ToString()) + int.Parse(second.ToString());

                    if (carryOver == true)
                        sum++;

                    if (sum >= 10)
                    {
                        sum = sum - 10;
                        carryOver = true;
                    }
                    else
                        carryOver = false;

                    output = sum.ToString() + output;
                }

                if (carryOver == true)
                    output = 1 + output;

                return output;
            }
        }

        public static string Add_Answer(string a, string b)
        {
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString(); // Fix this!
        }
    }
}
