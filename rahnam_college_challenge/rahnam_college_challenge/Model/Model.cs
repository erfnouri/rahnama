using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rahnam_college_challenge.Model
{
    static internal class Model
    {
        static public Dictionary<string, Dictionary<string, string>> DB;
        static private string currentPlayer = "default";
        static public SortedList<string, int> score;
        public static Dictionary<string, string> getcurrentplayer()
        {   
            DB.TryGetValue(currentPlayer, out var result);

            return result;
        }

    }
}
