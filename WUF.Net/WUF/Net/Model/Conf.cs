using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.nations
{
    public class Conf
    {
		public string Name { get; set; }
		public string Adj { get; set; }
		public int NbMembers { get; set; }
		public string DoF { get; set; }

		public List<Nation> Nations { get; set; } = new List<Nation>();

		public Conf(String name, String adj, int nbMembers, String date)
		{
			this.Name = name;
			this.Adj = adj;
			this.NbMembers = nbMembers;
			this.DoF = date;
		}

        public override string ToString()
        {
			return Name;
        }
    }
}
