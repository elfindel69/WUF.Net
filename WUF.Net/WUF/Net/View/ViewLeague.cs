using System;


namespace WUF.Net.competition
{
    public class ViewLeague
    {
        
        public static void DoViewLeague(Model.ConfLeague lastConfLeague, string lastConfLeagueRes, Model.ConfLeague bestConfLeague,
            string bestConfLeagueRes)
        {
            Console.WriteLine(lastConfLeague.Name + " ("+lastConfLeague.Edition+")"+" :");
            Console.WriteLine("dernière Ligue: " + lastConfLeague.Level);
            Console.WriteLine("dernier resultat: " + lastConfLeagueRes + "\n");
            Console.WriteLine("meilleure Ligue: " + bestConfLeague.Level);
            Console.WriteLine("meilleur resultat: " + bestConfLeagueRes + "\n");
        }
    }
}
