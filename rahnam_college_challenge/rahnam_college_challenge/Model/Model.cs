using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rahnam_college_challenge.model
{
    static internal class Model
    {
        static public Dictionary<string, Dictionary<string, string>> collection;
        static private string currentDb = "default";
        public static Dictionary<string, string> getCurrentDB()
        {   
            collection.TryGetValue(currentDb, out var result);
            return result;
        }
    }
}
