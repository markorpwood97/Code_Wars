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

        static void Split_Strings_C()
        {
            string[] output = Split_Strings.Solution("abc");
            Console.WriteLine(output);
        }

        static void Array_Diff_NC()
        {
            int[] output = Array_Diff.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 });
            Console.WriteLine(output);
        }

        static void Simple_Pig_Latin_C()
        {
            string hex = RGB_To_Hex_Conversion.Rgb_Answer(260, -255, 255);
            Console.WriteLine(hex);
        }

        static void Roman_Numerals_Encoder_NC()
        {
            string hex = RGB_To_Hex_Conversion.Rgb_Answer(260, -255, 255);
            Console.WriteLine(hex);
        }

        static void RGB_To_Hex_ConversionTesting()
        {
            string hex = RGB_To_Hex_Conversion.Rgb_Answer(260, -255, 255);
            Console.WriteLine(hex);
        }

        static void Maximum_Subarray_Sum_Testing()
        {
            int maxSum = Maximum_Subarray_Sum.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, 1, -5, 4 });
            Console.WriteLine(maxSum);
        }

        static void Friend_Or_Foe_Testing()
        {
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            var test = Friend_Or_Foe.FriendOrFoe(names);
            Console.WriteLine(test.ToArray());
        }

        static void IQ_Testing()
        {
            int IQDiff;
            IQDiff = IQ_Test.IQTest("2 50000000000000000000000 4 7 8 10 ");
            Console.WriteLine(IQDiff);
            IQDiff = IQ_Test.IQTest("1 2 2");
            Console.WriteLine(IQDiff);
        }

        static void FaceBook_Likes()
        {
            string likes;
            likes = Facebook_Likes.Likes(new string[0]);
            Console.WriteLine(likes);
            likes = Facebook_Likes.Likes(new string[] { "Peter" });
            Console.WriteLine(likes);
            likes = Facebook_Likes.Likes(new string[] { "Jacob", "Alex" });
            Console.WriteLine(likes);
            likes = Facebook_Likes.Likes(new string[] { "Max", "John", "Mark" });
            Console.WriteLine(likes);
            likes = Facebook_Likes.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" });
            Console.WriteLine(likes);
        }
    }
}
