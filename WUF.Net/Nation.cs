using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.country;

namespace WUF.Net.nations
{
    public class Nation : Country
    {
		public Conf Conf { get; set; }
		public string DoA { get; set; }
		public string Stadium { get; set; }
		public int RWuf { get; set; }
		public int RConf { get; set; }

		public Nation(string name, double pts, Conf conf, string stadium, string date, int rWuf, int rConf) : base(name, pts, 0)
		{
			
			this.Conf = conf;
			this.Stadium = stadium;
			this.DoA = date;
			this.RWuf = rWuf;
			this.RConf = rConf;

		}
	}
}
