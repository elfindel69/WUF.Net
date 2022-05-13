using System;
using System.Collections.Generic;
using WUF.Net.competition;
using WUF.Net.matches;
using WUF.Net.nations;

namespace WUF.Net
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Conf> confs = Controller.DataController.InitData();
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
					
					
					
					int confMenu = ViewConf.MenuConf(confs);
					//Europe
					
					if (confMenu == 1)
                    {
                        Conf europe = confs[0];
                        ViewConf.DoViewConf(europe);



                        int natMenu = nations.ViewNation.MenuNations(europe.Nations);

                        Nation natEu = europe.Nations[natMenu - 1];
						Controller.NationController.ViewNation(natEu);

                    }
                    //Amériques
                    if (confMenu == 2)
                    {
						Conf americas = confs[1];
						ViewConf.DoViewConf(americas);

						

						int natMenu = nations.ViewNation.MenuNations(americas.Nations);
						
						
						Nation natAm = americas.Nations[natMenu -1];
						Controller.NationController.ViewNation(natAm);

					}

				}
				Console.WriteLine("Quitter ? y/n");
				saisie = Console.ReadKey(true);
			} while (saisie.Key != ConsoleKey.Y);

		}

       
    }
}
