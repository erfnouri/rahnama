using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace rahnam_college_challenge
{
    public interface IGame
    {
        bool checkFirstDigit(string word);
        int checkIfExist(string user, string filed, string word);
        bool setScore(string user, int score);
        SortedList<string, int>returnScore();
    }
}