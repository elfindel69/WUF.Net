using System;


namespace WUF.Net.matches
{
    public class Match
    {
		public string Nat1 { get; set; }
		public string Nat2 { get; set; }
		public int Sc1 { get; set; }
		public int Sc2 { get; set; }
		public DateTime DoM { get; set; }
        public TimeZoneInfo TimeZone { get; internal set; }

        public Match(string nat1, int sc1, string nat2, int sc2, DateTime date, TimeZoneInfo timeZone)
		{
			this.Nat1 = nat1;
			this.Sc1 = sc1;
			this.Nat2 = nat2;
			this.Sc2  = sc2;
			this.DoM = date;
			this.TimeZone = timeZone;
		}
	}
}
