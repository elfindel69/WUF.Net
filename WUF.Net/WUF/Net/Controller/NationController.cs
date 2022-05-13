using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WUF.Net.competition;
using WUF.Net.matches;
using WUF.Net.nations;

namespace WUF.Net.Controller
{
    public class NationController
    {
        public static void ViewNation(Nation natEu)
        {
            nations.ViewNation.DoViewNation(natEu);

            ViewCup.DoViewCup(natEu.LastWorldCup, natEu.WorldCupParticipations, natEu.BestWorldCupRes, natEu.BestWorldCup);

            ViewCup.DoViewCup(natEu.LastConfCup, natEu.ConfCupParticipations, natEu.BestConfCupRes, natEu.BestConfCup);

            ViewLeague.DoViewLeague(natEu.LastConfLeague, natEu.LastConfLeagueRes, natEu.BestConfLeague, natEu.BestConfLeagueRes);



            char[] results = natEu.GetLast5Results();
            for (int i = 0; i < results.Length; i++)
            {
                Console.Write(results[i]);
            }
            Console.Write("\n\n");


            for (int i = 0; i < 5; i++)
            {
                ViewMatches.DoViewMatches(natEu.Matches[i]);
            }
        }

       
    }
}
