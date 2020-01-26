using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public static class Friend_Or_Foe
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(n => n.Length == 4);
        }        
    }
}
