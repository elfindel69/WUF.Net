using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.matches;
using WUF.Net.nations;

namespace WUF.Net.Controller
{
    public class DataController
    {
        public static List<Conf> InitData()
        {
			Conf americas = new Conf("Amériques", "américain", 41, "2018");
			Nation usa = new Nation("Etats-Unis", 1373.41, 0, americas, "FedEx Field", "2018", 10, 1);
			Model.Cup worldCup2021 = new Model.WorldCup("Coupe du Monde", "2021", usa, new DateTime(2021, 06, 03), new DateTime(2021, 07, 17));
			List<Conf> confs = new List<Conf>();
			Conf europe = new Conf("Europe", "européen", 54, "2018");
			Nation allemagne = new Nation("Allemagne", 1133.98, 0, europe, "Olympiastadion Berlin", "2018", 28, 12);
			Model.Cup euCup2019 = new Model.ConfCup("Coupe d'Europe", "2019", allemagne, new DateTime(2019, 06, 03), new DateTime(2019, 07, 06), europe);

			Model.ConfLeague eu1A2019 = new Model.ConfLeague("Ligue des Nations - Europe", "2020", "1A", europe);

			Model.ConfLeague eu2A2019 = new Model.ConfLeague("Ligue des Nations - Europe", "2020", "2A", europe);
			TimeZoneInfo euZone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");
			TimeZoneInfo ukZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
			Nation france = new Nation("France", 1294.97, 0, europe, "Stade de France", "2018", 13, 6);
			france.WorldCupParticipations = 1;
			france.BestWorldCup = worldCup2021;
			france.LastWorldCup = worldCup2021;
			france.LastWorldCupRes = "quarts de finale";
			france.BestWorldCupRes = "quarts de finale";
			france.ConfCupParticipations = 1;
			france.BestConfCup = euCup2019;
			france.LastConfCup = euCup2019;
			france.LastConfCupRes = "finaliste";
			france.BestConfCupRes = "finaliste";
			france.LastConfLeague = eu1A2019;
			france.LastConfLeagueRes = "3eme";
			france.BestConfLeague = eu1A2019;
			france.BestConfLeagueRes = "3eme";
			france.TimeZone = "Romance Standard Time";

			List<Match> tabMatches = new List<Match>();

			DateTime locDate1 = new DateTime(2021, 11, 20, 20, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Angleterre", 18, "France", 16, locDate1, euZone));

			DateTime locDate2 = new DateTime(2021, 11, 13, 20, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Irlande", 14, "France", 16, locDate2, euZone));

			DateTime locDate3 = new DateTime(2021, 07, 09, 01, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Nouvelle-Zélande", 85, "France", 51, locDate3, euZone));

			DateTime locDate4 = new DateTime(2021, 07, 02, 01, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Croatie", 14, "France", 42, locDate4, euZone));

			DateTime locDate5 = new DateTime(2021, 06, 27, 01, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Afrique du Sud", 52, "France", 13, locDate5, euZone));

			france.Matches = tabMatches;
			europe.Nations.Add(france);
			Nation italy = new Nation("Italie", 1153.25, 0, europe, "Stadio Olympico", "2018", 25, 10);
			italy.WorldCupParticipations = 0;
			italy.BestWorldCup = worldCup2021;
			italy.LastWorldCup = worldCup2021;
			italy.BestWorldCupRes = "qualifications";
			italy.LastWorldCupRes = "qualifications";
			italy.ConfCupParticipations = 1;
			italy.BestConfCup = euCup2019;
			italy.LastConfCup = euCup2019;
			italy.BestConfCupRes = "quarts de finale";
			italy.LastConfCupRes = "quarts de finale";
			italy.LastConfLeague = eu2A2019;
			italy.LastConfLeagueRes = "3eme";
			italy.BestConfLeague = eu2A2019;
			italy.BestConfLeagueRes = "3eme";
			italy.TimeZone = "Romance Standard Time";
			tabMatches = new List<Match>();

			locDate1 = new DateTime(2021, 10, 23, 19, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Italie", 9, "Pays de Galles", 16, locDate1, euZone));

			locDate2 = new DateTime(2021, 10, 16, 19, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Croatie", 14, "Italie", 16, locDate2, euZone));

			locDate3 = new DateTime(2021, 09, 18, 19, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Italie", 16, "Russie", 14, locDate3, euZone));

			locDate4 = new DateTime(2021, 09, 11, 19, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Allemagne", 14, "Italie", 16, locDate4, euZone));

			locDate5 = new DateTime(2021, 08, 21, 19, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Suisse", 23, "Italie", 13, locDate5, euZone));
			italy.Matches = tabMatches;
			europe.Nations.Add(italy);
			Nation england = new Nation("Angleterre", 1877.43, 0, europe, "Twickenham Stadium", "2018", 1, 1);
			england.WorldCupParticipations = 1;
			england.BestWorldCup = worldCup2021;
			england.LastWorldCup = worldCup2021;
			england.BestWorldCupRes = "4eme";
			england.LastWorldCupRes = "4eme";
			england.ConfCupParticipations = 1;
			england.BestConfCup = euCup2019;
			england.LastConfCup = euCup2019;
			england.BestConfCupRes = "vainqueur";
			england.LastConfCupRes = "vainqueur";
			england.LastConfLeague = eu1A2019;
			england.LastConfLeagueRes = "2eme";
			england.BestConfLeague = eu1A2019;
			england.BestConfLeagueRes = "2eme";
			england.TimeZone = "GMT Standard Time";

			tabMatches = new List<Match>();

			locDate1 = new DateTime(2021, 11, 20, 20, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Angleterre", 18, "France", 16, locDate1, ukZone));

			locDate2 = new DateTime(2021, 10, 16, 16, 30, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Angleterre", 16, "Pays de Galles", 14, locDate2, ukZone));

			locDate3 = new DateTime(2021, 07, 17, 01, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Angleterre", 38, "Afrique du Sud", 40, locDate3, ukZone));

			locDate4 = new DateTime(2021, 07, 13, 22, 30, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Angleterre", 121, "Australie", 127, locDate4, ukZone));

			locDate5 = new DateTime(2021, 07, 07, 22, 30, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Irlande", 15, "Angleterre", 55, locDate5, ukZone));

			england.Matches = tabMatches;
			europe.Nations.Add(england);
			confs.Add(europe);
			Model.Cup amCup2019 = new Model.ConfCup("Coupe des Amériques", "2019", usa, new DateTime(2019, 04, 01),
						new DateTime(2019, 05, 04), americas);

			Model.ConfLeague am1A2019 = new Model.ConfLeague("Ligue des Nations - Amériques", "2020", "1A", americas);
			TimeZoneInfo usaEast = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
			usa.WorldCupParticipations = 1;
			usa.BestWorldCup = worldCup2021;
			usa.LastWorldCup = worldCup2021;
			usa.BestWorldCupRes = "huitièmes de finale";
			usa.LastWorldCupRes = "huitièmes de finale";
			usa.ConfCupParticipations = 1;
			usa.BestConfCup = amCup2019;
			usa.LastConfCup = amCup2019;
			usa.BestConfCupRes = "vainqueur";
			usa.LastConfCupRes = "vainqueur";
			usa.LastConfLeague = am1A2019;
			usa.LastConfLeagueRes = "vainqueur";
			usa.BestConfLeague = am1A2019;
			usa.BestConfLeagueRes = "vainqueur";
			usa.TimeZone = "Eastern Standard Time";
			tabMatches = new List<Match>();

			locDate1 = new DateTime(2021, 11, 21, 02, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Etats-Unis", 16, "Panama", 14, locDate1, usaEast));

			locDate2 = new DateTime(2021, 11, 14, 02, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Etats-Unis", 16, "Canada", 14, locDate2, usaEast));

			locDate3 = new DateTime(2021, 06, 30, 01, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Etats-Unis", 23, "Japon", 73, locDate3, usaEast));

			locDate4 = new DateTime(2021, 06, 25, 01, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Etats-Unis", 21, "Suède", 20, locDate4, usaEast));

			locDate5 = new DateTime(2021, 06, 19, 01, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Etats-Unis", 145, "Namibie", 19, locDate5, usaEast));

			usa.Matches = tabMatches;
			americas.Nations.Add(usa);
			Nation canada = new Nation("Canada", 1336.97, 0, americas, "TD Place", "2018", 11, 2);
			canada.WorldCupParticipations = 1;
			canada.BestWorldCup = worldCup2021;
			canada.LastWorldCup = worldCup2021;
			canada.BestWorldCupRes = "huitièmes de finale";
			canada.LastWorldCupRes = "huitièmes de finale";
			canada.ConfCupParticipations = 1;
			canada.BestConfCup = amCup2019;
			canada.LastConfCup = amCup2019;
			canada.BestConfCupRes = "finaliste";
			canada.LastConfCupRes = "finaliste";
			canada.LastConfLeague = am1A2019;
			canada.LastConfLeagueRes = "2eme";
			canada.BestConfLeague = am1A2019;
			canada.BestConfLeagueRes = "2eme";
			canada.TimeZone = "Eastern Standard Time";
			tabMatches = new List<Match>();

			locDate1 = new DateTime(2021, 11, 14, 02, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Etats-Unis", 16, "Canada", 14, locDate1, usaEast));

			locDate2 = new DateTime(2021, 10, 17, 01, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Canada", 16, "Mexique", 9, locDate2, usaEast));

			locDate3 = new DateTime(2021, 09, 18, 23, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Canada", 16, "Argentine", 9, locDate3, usaEast));

			locDate4 = new DateTime(2021, 07, 01, 01, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Canada", 31, "Ecosse", 105, locDate4, usaEast));

			locDate5 = new DateTime(2021, 06, 26, 23, 00, 00, DateTimeKind.Utc);
			tabMatches.Add(new Match("Canada", 63, "Kenya", 55, locDate5, usaEast));

			canada.Matches = tabMatches;
			americas.Nations.Add(canada);
			confs.Add(americas);
			return confs;
		}
    }
}
