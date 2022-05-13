using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.Model;

namespace WUF.Net.competition
{
    public class ViewCup
    {
     
        internal static void DoViewCup(Cup lastCup, int cupParticipations, string lastCupRes, Cup bestCup)
        {
            Console.WriteLine("\n" + lastCup.Name + ":");
            Console.WriteLine("participations: " + cupParticipations);
            Console.WriteLine("meilleur résultat: " + lastCupRes + " (" + bestCup.Edition + ") \n");
        }
    }
}
