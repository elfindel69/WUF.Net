using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WUF.Net.matches
{
	[Table("Match")]
	public class Match
    {
		public int MatchId { get; set; }
		public string Nat1 { get; set; }
		public string Nat2 { get; set; }
		public int Sc1 { get; set; }
		public int Sc2 { get; set; }
		public DateTime DoM { get; set; }

		public String TimeZone { get; set; }
		public Match(string nat1, int sc1, string nat2, int sc2, DateTime zoneDate1, String timeZone1)
		{
			this.Nat1 = nat1;
			this.Sc1 = sc1;
			this.Nat2 = nat2;
			this.Sc2  = sc2;
			this.DoM = zoneDate1;
			this.TimeZone = timeZone1;
		}
	}
}
