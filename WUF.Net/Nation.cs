using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.country;

namespace WUF.Net.nations
{
    public class Nation : Country
    {
		public int Id { get; set; }
		public Conf Conf { get; set; }
		public string DoA { get; set; }
		public string Stadium { get; set; }
		public int RWuf { get; set; }
		public int RConf { get; set; }

		public Nation(int id, string name, double pts, Conf conf, string stadium, string date, int rWuf, int rConf) : base(name, pts, 0)
		{
			this.Id = id;
			this.Conf = conf;
			this.Stadium = stadium;
			this.DoA = date;
			this.RWuf = rWuf;
			this.RConf = rConf;

		}
	}
}
