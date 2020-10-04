using MySql.Data.MySqlClient;
using System;

namespace WUF.Net
{
    class Program
    {
        static void Main(string[] args)
        {
			MySqlConnection conn = DBUtils.GetDBConnection();
			try
			{
				Console.WriteLine("Openning Connection ...");

				conn.Open();

				Console.WriteLine("Connection successful!");
			}
			catch (Exception e)
			{
				Console.WriteLine("Error: " + e.Message);
			}
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
				//view nations
				if (startMenu == 3)
				{

					ContMenu.ViewNations(conn);

				}
				//add conf
				if (startMenu == 4)
				{

					ContMenu.AddConf(conn);

				}
				//add nation
				if (startMenu == 5)
				{

					ContMenu.AddNation(conn);

				}
				//add match
				if (startMenu == 6)
				{

					ContMenu.AddMatch(conn);

				}
				Console.WriteLine("Quitter ? y/n");
				saisie = Console.ReadKey(true);
			} while (saisie.Key != ConsoleKey.Y);
			// Terminez la connexion.
			conn.Close();
			// Disposez un objet, libérez des ressources.
			conn.Dispose();
		}
	}
}
