using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.country
{
   public class Country
    {
		public string Name { get; set; }
		public double Pts { get; set; }
		public int Score { get; set; }

		public Country(String name, double pts, int score)
		{
			this.Name = name;
			this.Pts = pts;
			this.Score = score;
		}
	}
}
