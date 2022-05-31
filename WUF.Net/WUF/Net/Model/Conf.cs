using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WUF.Net.nations
{
	[Table("Conf")]
    public class Conf
    {
		[System.ComponentModel.DataAnnotations.Key]
		public int ConfId { get; set; }

		public string Name { get; set; }
		public string Adj { get; set; }
		public int NbMembers { get; set; }
		public string DoF { get; set; }

		public virtual List<Nation> Nations { get; set; } = new List<Nation>();
		public virtual List<Model.ConfCup> ConfCups { get; set; } = new List<Model.ConfCup>();
		public virtual List<Model.ConfLeague> ConfLeagues { get; set; } = new List<Model.ConfLeague>();	


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
