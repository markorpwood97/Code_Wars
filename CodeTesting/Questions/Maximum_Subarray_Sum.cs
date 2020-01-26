using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public class Maximum_Subarray_Sum
    {
        public static int MaxSequence(int[] arr)
        {
            int maxNum = 0;
            int prevSum = 0;

            arr.ToList().ForEach(i => { prevSum += i; if (prevSum < 0) { prevSum = 0; } if (maxNum < prevSum) { maxNum = prevSum; } });
            
            return maxNum;
        }
    }
}
