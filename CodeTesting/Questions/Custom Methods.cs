using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public static class Custom_Methods
    {
        public static int duplicates;

        public static int CountDuplicates()
        {
            string str = "sdfgfghfdgsg";

            str = str.ToLower();
            char[] list = str.ToCharArray();
            char[] list2 = str.ToCharArray();
            char[] list3 = new char[0];

            int num = 0;

            foreach (char i in list)
            {
                if (list2.Contains(i))
                {}
                else if (list3.Contains(i))
                {
                    num++;
                    //list2 = list2.;
                }
            }
            return num;
        }
    }
}
