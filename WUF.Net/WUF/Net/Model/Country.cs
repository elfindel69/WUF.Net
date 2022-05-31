using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WUF.Net.country
{
	[Table("Country")]
   public class Country
    {
		[System.ComponentModel.DataAnnotations.Key]
		public int CountryId { get; set; }
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
