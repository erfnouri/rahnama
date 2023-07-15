using System.Text.RegularExpressions;
using rahnam_college_challenge.Startup;

namespace rahnam_college_challenge
{
    //sample input
    //"user1 name: jack lastname: jacknezhad city: jackabad food: jackpolo
    //user2 name: joans lastname: joansnezhad city: null food: joanspolo"
    public class Progarm
    {
        public static void Main()
        {
            var DB = Setup.Configuration();
            while (true)
            {
                var str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                dynamic result;
                if (strArr[0] == "exit")
                    Environment.Exit(0);
                if (strArr[0] == "result")
                {
                    foreach(string user in Model.Model.DB.Keys)
                    {
                        Model.Model.DB.TryGetValue(user, out var table);
                        foreach (var value in table)
                        {
                            if(DB.checkFirstDigit(value.Value))
                                DB.setScore(user,DB.checkIfExist(user,value.Key,value.Value));
                        }
                    }
                    Console.WriteLine(DB.returnScore());
                }
                Model.Model.DB.Add(strArr[0], new Dictionary<string, string>());
                for(int i = 1; i < strArr.Length; i+=2)
                {
                    if (strArr[i+1] == "null")
                    {
                        strArr[i + 1] = "1ncorrect";
                    }
                    Model.Model.DB[strArr[0]].Add(strArr[i], strArr[i+1]);
                }
                

            }

        }
    }
}