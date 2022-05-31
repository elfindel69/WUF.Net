using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WUF.Net.country;
using WUF.Net.matches;
using WUF.Net.Model;

namespace WUF.Net.nations
{
	[Table("Nation")]
	public class Nation : Country
    {
		[ForeignKey("Conf")]
		public int ConfId { get; set; }
		public virtual Conf Conf { get; set; }
		public string DoA { get; set; }
		public string Stadium { get; set; }
		public int RWuf { get; set; }
		public int RConf { get; set; }

		public int WorldCupParticipations { get; set; }
		public string LastWorldCupRes { get; set; }

		[ForeignKey("WorldCup")]
		public int LastWorldCupId { get; set; }
		public virtual Model.Cup LastWorldCup { get; set; }
		public string BestWorldCupRes { get; set; }

		[ForeignKey("WorldCup")]
		public int BestWorldCupId { get; set; }
		public virtual Cup BestWorldCup { get; set; }

		public int ConfCupParticipations { get; set; }
		public string LastConfCupRes { get; set; }

		[ForeignKey("ConfCup")]
		public int LastConfCupId { get; set; }
		public virtual Model.Cup LastConfCup { get; set; }
		public string BestConfCupRes { get; set; }
		public Cup BestConfCup { get; internal set; }

		[ForeignKey("ConfLeague")]
		public int LastConfLeagueId { get; set; }
		public virtual Model.ConfLeague LastConfLeague { get; set; }
		public string LastConfLeagueRes { get; set; }

		[ForeignKey("ConfLeague")]
		public int BestConfLeagueId { get; set; }
		public virtual Model.ConfLeague BestConfLeague { get; set; }
		public string BestConfLeagueRes { get; set; }

		public List<Match> Matches { get; set; } = new List<Match>();

		public string TimeZone { get; set; }
      

        public Nation(string name, double pts, int score, Conf conf, string stadium, string date, int rWuf, int rConf) : base (name, pts, score)
		{
			
			this.Conf = conf;
			this.Stadium = stadium;
			this.DoA = date;
			this.RWuf = rWuf;
			this.RConf = rConf;

		}


		public Char[] GetLast5Results()
        {
			Match[] arr = Matches.ToArray();
			Char[] results = new Char[5];
			for(int i = 0; i < 5; i++)
            {
                if ((arr[i].Nat1.Equals(Name) && arr[i].Sc1 > arr[i].Sc2) || (arr[i].Nat2.Equals(Name) && arr[i].Sc1 < arr[i].Sc2))
                {
					results[i] = 'V';
                }
				else if (arr[i].Sc1 == arr[i].Sc2)
				{
					results[i] = 'N';
				}
                else
                {
					results[i] = 'D';
                }
			}
			return results;
        }

		public override string ToString()
		{
			return Name;
		}
	}
}
