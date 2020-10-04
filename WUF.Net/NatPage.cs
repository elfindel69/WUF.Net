using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.competition;
using WUF.Net.matches;
using WUF.Net.nations;

namespace WUF.Net
{
    class NatPage
    {
		public Nation Nat { get; set; }
		public List<Cup> LCups  { get; set; }
		public League League { get; set; }
		public List<Match> LMatches { get; set; }
		public char[] TabResults { get; set; }

		public NatPage(Nation nat, List<Cup> lCups, League league, List<Match> lMatches, char[] tabResults)
		{
			this.Nat = nat;
			this.LCups = lCups;
			this.League = league;
			this.LMatches = lMatches;
			this.TabResults = tabResults;
		}
	}
}
