
namespace distination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Destination(new List<List<string>>{new List<string>{"London","New York"},new List<string>{"New York","Lima"},new List<string>{"Lima","Sao Paulo"}}));
        }

        private static string Destination(List<List<string>> paths)
        {
            HashSet<string> StartCity = new HashSet<string>();
         
            string[] DistinationCity = new string[paths.Count];
            int i = 0;
            foreach(List<string> path in paths)
            {
                StartCity.Add(path[0]);
                DistinationCity[i++] = path[1];
            }

            foreach(string city in DistinationCity)
            {
                if(!StartCity.Contains(city))
                {
                    return city;
                }
            }
            return "";
        }
    }
}
