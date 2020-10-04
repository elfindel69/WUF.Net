using System;

namespace WUF.Net
{
    class ViewMenu
    {
		internal static int StartMenu()
		{
			Console.WriteLine("Menu:");
			Console.WriteLine("1. scores...");
			Console.WriteLine("2. points...");
			Console.WriteLine("3. view nations...");
			Console.WriteLine("4. add conf...");
			Console.WriteLine("5. add nation...");
			Console.WriteLine("6. add match...");
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
		}
	}
}
