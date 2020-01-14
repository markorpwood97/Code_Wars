using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars.Questions
{
    public class Categorize_New_Member
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> output = new List<string>();

            //return data.Where(item => item[1] >= 55 && item[1] > 7);


            foreach (var item in data)
            {
                if (item[0] >= 55 && item[1] > 7)
                {

                }
            }

            return output;
        }
    }
}
