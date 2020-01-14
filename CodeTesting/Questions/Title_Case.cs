using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars.Questions
{
    public class Title_Case
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            if (title == "")
                return "";
            string output = "";
            var words = title.ToLower().Split(' ');
            string[] minWords = "".Split(' ');
            if (minorWords != null)
                minWords = minorWords.ToLower().Split(' ');
            int i = 1;
            foreach (var word in words)
            {
                if (i == 1)
                {
                    output += char.ToUpper(word[0]) + word.Substring(1);
                    i++;
                }
                else if (minorWords == null)
                {
                    output += " " + char.ToUpper(word[0]) + word.Substring(1);
                }
                else if (!IsMinorWord(word, minWords))
                {
                    output += " " + char.ToUpper(word[0]) + word.Substring(1);
                }
                else
                    output += " " + word;
            }

            return output;
        }

        public static bool IsMinorWord(string word, string[] minorWords)
        {
            foreach (var minWord in minorWords)
            {
                if (word == minWord)
                {
                    return true;
                }
            }

            return false;
        }

        //Answer
        static string FirstToUpper(string input)
        {
            var s = input.ToCharArray();
            s[0] = Char.ToUpper(s[0]);
            return new String(s);
        }

        public static string TitleCase_Answer(string title, string minorWords = "")
        {
            if (String.IsNullOrEmpty(title)) return title;

            var titleWords = title.Split(' ').Select(w => w.ToLower());
            var minWords = (minorWords ?? "").Split(' ').Select(w => w.ToLower());

            return FirstToUpper(String.Join(" ", titleWords.Select(w => minWords.Contains(w) ? w : FirstToUpper(w))));
        }

    }
}
