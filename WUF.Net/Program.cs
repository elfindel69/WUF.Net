using MySqlConnector;
using System;
using System.Collections.Generic;
using WUF.Net.competition;
using WUF.Net.Controller;
using WUF.Net.matches;
using WUF.Net.Model;
using WUF.Net.nations;

namespace WUF.Net
{
    class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("Getting Connection ...");
			MySqlConnection conn = Controller.DAOController.GetDBConnection();

			try
			{
				Console.WriteLine("Openning Connection ...");

				conn.Open();
				Console.WriteLine("Connection successful!");
				using (var context = new MyContext())
				{
					WUFBoard wuf = Controller.DataController.InitData(conn);
					context.WUFBoard.Add(wuf);
					context.SaveChanges();
					ConsoleKeyInfo saisie;
					do
					{

						//menu principal
						int startMenu = ViewMenu.StartMenu();
						//scores
						if (startMenu == 1)
						{
							ContMenu.ExecScores();
						}
						//points
						if (startMenu == 2)
						{

							ContMenu.ExecPoints();
						}
						//nations
						if (startMenu == 3)
						{



							int confMenu = ViewConf.MenuConf(wuf.Confs);
							//Europe

							if (confMenu == 1)
							{
								Conf europe = wuf.Confs[0];
								ViewConf.DoViewConf(europe);



								int natMenu = nations.ViewNation.MenuNations(europe.Nations);

								Nation natEu = europe.Nations[natMenu - 1];
								Controller.NationController.ViewNation(natEu);

							}
							//Amériques
							if (confMenu == 2)
							{
								Conf americas = wuf.Confs[1];
								ViewConf.DoViewConf(americas);



								int natMenu = nations.ViewNation.MenuNations(americas.Nations);


								Nation natAm = americas.Nations[natMenu - 1];
								Controller.NationController.ViewNation(natAm);

							}

						}
						//World ranking
						if (startMenu == 4)
						{
							List<Nation> list = Controller.RankingController.Ranking(wuf.Nations);
							Controller.RankingController.ViewRanking(list);
						}
						Console.WriteLine("Quitter ? y/n");
						saisie = Console.ReadKey(true);
					} while (saisie.Key != ConsoleKey.Y);

				}
				
				conn.Close();
				Console.WriteLine("Connection closed");
			}

			catch (Exception e)
			{
				Console.WriteLine("Error: " + e.Message);
			}

			

		}

       
    }
}
