using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.nations;

namespace WUF.Net.Model
{
    public class WUFBoard
    {
        public string Name { get; set; }
        public string Adj { get; set; }
        public int NbMembers { get; set; }
        public string DoF { get; set; }

        public List<Conf> Confs { get; set; }   = new List<Conf>();
        public List<Nation> Nations { get; set; } = new List<Nation>();

        public List<WorldCup> worldCups { get; set; } = new List<WorldCup>();

        public WUFBoard(String name, String adj, int nbMembers, String date)
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
