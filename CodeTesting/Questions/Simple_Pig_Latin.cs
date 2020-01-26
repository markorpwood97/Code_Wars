using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public class Simple_Pig_Latin
    {
        public static string PigIt(string str)
        {
            string[] words = str.Split(' ');
            string pigSentence = "";
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            int i = 0;

            foreach (var word in words)
            {
                i++;
                if (!word.Contains(specialChar))
                {
                    //char firstLetter = word[0];
                    var firstLetter = word.First();

                    var restOfWord = word.Substring(1);

                    if (i != words.Count())
                        pigSentence += restOfWord + firstLetter.ToString() + "ay ";
                    else
                        pigSentence += restOfWord + firstLetter.ToString() + "ay";

                }
                else
                    pigSentence += word;
            }


            return pigSentence;
        }

        public static string PigIt_Answer(string str)
        {
            return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
        }
    }
}
