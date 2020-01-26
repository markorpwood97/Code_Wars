using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public static class Facebook_Likes
    {
        public static string Likes(string[] name)
        {
            string likeText = "";

            int likeCount = name.Length;

            switch (likeCount)
            {
                case 0:
                    likeText = "no one likes this";
                    break;
                case 1:
                    likeText = name[0] + " likes this";
                    break;
                case 2:
                    likeText = name[0] + " and " + name[1] + " like this";
                    break;
                case 3:
                    likeText = name[0] + ", " + name[1] + " and " + name[2] + " like this";
                    break;
                default:
                    likeText = name[0] + ", " + name[1] + " and " + (likeCount - 2) + " others like this";
                    break;
            }

            return likeText;
        }
    }
}
