using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.competition
{
    class League
    {
		public string Name { get; set; }
		public string LLeague { get; set; }
		public string Result { get; set; }
		public string Year { get; set; }

		public League(string name, string league, string result, string year)
		{
			this.Name = name;
			this.LLeague = league;
			this.Result = result;
			this.Year = year;
		}
	}
}
