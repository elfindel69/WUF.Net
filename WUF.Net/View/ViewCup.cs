using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.competition
{
    public class ViewCup
    {
        public static void DoViewCup(string name, int nb, string result, string date)
        {
            Console.WriteLine("\n" + name + ":");
            Console.WriteLine("appearances: " + nb);
            Console.WriteLine("best result: " + result + "(" + date + ") \n");
        }
    }
}
