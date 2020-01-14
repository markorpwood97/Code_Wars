using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars.Questions
{
    public class SumOfDigits
    {
        public static int DigitalRoot(long n)
        {
            char[] nums = n.ToString().ToCharArray();

            while (nums.Count() > 1)
            {
                int total = 0;

                foreach (var num in nums)
                {
                    ///*var numInt = */ int.TryParse(num, out int test);
                    //total += test;
                }

                //nums = total.ToString().Split();
            }

            //int.TryParse(nums[0], out int output);
            
            return 5;
        }
    }
}
