using System;


namespace WUF.Net.competition
{
    public class ViewLeague
    {
        public static void DoViewLeague(string name, string league, string result)
        {
            Console.WriteLine(name + " :");
            Console.WriteLine("current League: " + league);
            Console.WriteLine("best result: " + result + "\n");
        }
    }
}
