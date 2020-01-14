using Code_Wars.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Code_Wars
{
    class Programd
    {
        public static void Main(string[] args)
        {
            string output = Adding_Big_Numbers.Add("91", "19");
            Console.WriteLine(output);
            
        }

        public static void Detect_Pangram_NC(string[] args)
        {
            var output = Detect_Pangram.IsPangram("Test");
            Console.WriteLine(output);
        }
        
        public static void SumOfDigits_NC(string[] args)
        {
            var output = SumOfDigits.DigitalRoot(157);
            Console.WriteLine(output);
        }

        public static void Title_Case_C(string[] args)
        {
            var output = Title_Case.TitleCase("First a of in", null);
            Console.WriteLine("First A Of In");
            Console.WriteLine(output);
        }

        public static void Sum_Of_Two_Lowest_Positive_Integers_C(string[] args)
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            int output = Sum_Of_Two_Lowest_Positive_Integers.sumTwoSmallestNumbers(numbers);
            Console.WriteLine(output);
        }

        public static void Categorize_New_Member_NC(string[] args)
        {
            var test = Categorize_New_Member.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } });

            Console.WriteLine(test);
        }
    }
}
