using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.competition
{
    class ViewCup
    {
        public static void DoViewCup(Cup cup)
        {
            Console.WriteLine("\n" + cup.Name + ":");
            Console.WriteLine("appearances: " + cup.NbCups);
            Console.WriteLine("best result: " + cup.Result + "(" + cup.Year + ") \n");
        }

        internal static Cup AddCup(MySqlConnection conn)
        {
            Console.WriteLine("New Cup:");
            Console.WriteLine("name: ");
            string name = Console.ReadLine();
            Console.WriteLine("nbCups: ");
            string sPts = Console.ReadLine();
            int.TryParse(sPts, out int nbCups);
            Console.WriteLine("Best result: ");
            string result = Console.ReadLine();
            Console.WriteLine("year: ");
            string year = Console.ReadLine();
            return new Cup(name, nbCups, result, year);
        }
    }
}
