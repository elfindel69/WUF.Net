using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.competition
{
    class Cup
    {
		public string Name { get; set; }
		public int NbCups { get; set; }
		public string Result { get; set; }
		public string Year { get; set; }

		public Cup(string name, int nbCups, string result, string year)
		{
			this.Name = name;
			this.NbCups = nbCups;
			this.Result = result;
			this.Year = year;
		}
	}
}
