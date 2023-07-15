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

        bool IGame.checkIfExist(string word)
        {
            return true;
        }

        SortedList<int, string> IGame.returnScore()
        {
            throw new NotImplementedException();
        }

        bool IGame.setScore(string user, string filed, int score)
        {
            throw new NotImplementedException();
        }

    }
}
