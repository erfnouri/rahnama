using rahnam_college_challenge.Implementations;
using System.Reflection;
using rahnam_college_challenge;
using System.Text.RegularExpressions;


namespace rahnam_college_challenge.Startup
{
    public static class SetupCollections
    {

        public static IGame Configuration()
        {
            Model.Model.collection = new Dictionary<string, Dictionary<string, string>>();
            Model.Model.collection.TryAdd("default", new Dictionary<string, string>());
            return new InMemoryDatabase<string>();
        }
    }
}
