using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace rahnam_college_challenge
{
    public interface IGame
    {
        bool checkFirstDigit(string dbName);
        bool checkIfExist(string dbName);
        bool setScore(string user, string filed , int score);
        SortedList<int, string>returnScore();
    }
}