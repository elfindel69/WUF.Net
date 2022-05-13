using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net
{
    class ViewMenu
    {
		internal static int StartMenu()
		{
			Console.WriteLine("Menu:");
			Console.WriteLine("1. scores...");
			Console.WriteLine("2. points...");
			Console.WriteLine("3. nations...");
			Console.WriteLine("4. classement mondial...");
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
		}
	}
}
