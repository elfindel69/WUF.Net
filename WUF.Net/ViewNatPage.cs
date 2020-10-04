using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.competition;
using WUF.Net.matches;
using WUF.Net.nations;

namespace WUF.Net
{
    class ViewNatPage
    {
		public static void ViewPage(NatPage page)
		{
			ViewNation.DoViewNation(page.Nat);

			foreach (Cup c in page.LCups)
			{
				ViewCup.DoViewCup(c);
			}
			if (page.League != null)
			{
				ViewLeague.DoViewLeague(page.League);
			}

			for (int i = 0; i < page.TabResults.Length; i++)
			{
				Console.Write(page.TabResults[i]);
			}
			Console.Write("\n\n");

			foreach (Match item in page.LMatches)
			{
				ViewMatches.DoViewMatches(item);
			}
		}
	}
}
