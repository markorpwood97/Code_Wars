using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Code_Wars
{
    public class Split_Strings
    {
        public static string[] Solution(string str)
        {
            List<String> a = new List<String>();
            string split = "";
            char[] chars = str.ToCharArray();

            foreach (var item in chars)
            {
                split += item;
                if (split != item.ToString())
                {
                    a.Add(split);
                    split = "";
                }
            }

            if (chars.Count() %2 != 0)
            {
                split += "_";
                a.Add(split);
            }

            return a.ToArray();
        }

        public static string[] Solution_Answer(string str)
        {
            if (str.Length % 2 != 0)
                str += "_";
            return Enumerable.Range(0, str.Length)
              .Where(x => x % 2 == 0)
              .Select(x => str.Substring(x, 2))
              .ToArray();
        }
    }
}
