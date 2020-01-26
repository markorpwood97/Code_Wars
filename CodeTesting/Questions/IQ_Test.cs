using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public class IQ_Test
    {
        public static int IQTest(string numbers)
        {
            string[] numbersArray = numbers.Split(' ');
            int evenCount = 0;
            int oddCount = 0;
            bool IsOddOneOut;
            int numPossition = 1;

            for (int i = 0; i < 3; i++)
            {
                if (IsOdd(Int32.Parse(numbersArray[i])))
                    oddCount++;
                else
                    evenCount++;
            }

            if (evenCount > oddCount)
                IsOddOneOut = false;
            else
                IsOddOneOut = true;            

            foreach (var num in numbersArray)
            {
                if (IsOdd(Int32.Parse(num)) != IsOddOneOut)
                    return numPossition;

                numPossition++;
            }

            return 0;
        }

        private static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        public static int Answer(string numbers)
        {
            var ints = numbers.Split(' ').Select(int.Parse).ToList();
            var unique = ints.GroupBy(n => n % 2).OrderBy(c => c.Count()).First().First();
            return ints.FindIndex(c => c == unique) + 1;
        }
    }
}
