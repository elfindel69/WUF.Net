using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WUF.Net.nations;

namespace WUF.Net.Model
{
    [Table("WUFBoard")]
    public class WUFBoard
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int WUFBoardId { get; set; }
        public string Name { get; set; }
        public string Adj { get; set; }
        public int NbMembers { get; set; }
        public string DoF { get; set; }

        public virtual List<Conf> Confs { get; set; }   = new List<Conf>();
        public virtual List<Nation> Nations { get; set; } = new List<Nation>();

        public virtual List<WorldCup> worldCups { get; set; } = new List<WorldCup>();

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
