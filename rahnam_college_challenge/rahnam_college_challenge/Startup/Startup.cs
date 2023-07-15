namespace rahnam_college_challenge.Startup
{
    public static class Setup
    {
        private static string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static char mainChar;
        public static char GetRandomAlphabet()
        {
            Random rand = new Random();
            int index = rand.Next(0, chars.Length);
            return chars[index];
        }
        public static IGame Configuration()
        {
            mainChar = GetRandomAlphabet();
            Model.Model.DB = new Dictionary<string, Dictionary<string, string>>();
            Model.Model.DB.TryAdd("default", new Dictionary<string, string>());
            return new Game();
        }
    }
}
