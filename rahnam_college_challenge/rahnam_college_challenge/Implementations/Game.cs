using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rahnam_college_challenge;
using rahnam_college_challenge.Model;
using rahnam_college_challenge.Startup;

namespace rahnam_college_challenge
{
    internal class Game : IGame
    {
        bool IGame.checkFirstDigit(string word)
        {
            if (word[0] == Setup.mainChar)
                return true;
            else 
                return false;
        }

        int IGame.checkIfExist(string user, string filed, string word)
        {
            var DB = Model.Model.DB;
            foreach (KeyValuePair<string, Dictionary<string, string>> entry in DB)
            {
                if(entry.Key != user)
                {
                    entry.Value.TryGetValue(filed, out var value);
                    if (value == word)
                    {
                        return 5;
                    }
                }
            }
            return 10;
        }

        SortedList<string, int> IGame.returnScore()
        {
            var result = Model.Model.score;
            return result;
        }

        bool IGame.setScore(string user, int score)
        {
            try
            {
                Model.Model.score[user] += score;
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
