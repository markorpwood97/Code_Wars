using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars.Questions
{
    public static class Sum_Of_Two_Lowest_Positive_Integers
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            return (from n in numbers orderby n select n).Take(2).Sum();
        }

        public static int sumTwoSmallestNumbers_Answer(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();
        }
    }
}
