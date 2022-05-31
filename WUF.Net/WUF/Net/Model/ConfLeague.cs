using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WUF.Net.nations;

namespace WUF.Net.Model
{
    [Table("ConfLeague")]
    public class ConfLeague
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ConfLeagueId { get; set; }
        public string Name { get; set; }
        public string Edition { get; set; }

        public string Level { get; set; }

        public nations.Conf Conf { get; set; }

        public ConfLeague(string name, string edition, string level, Conf conf)
        {
            Name = name;
            Edition = edition;
            Level = level;
            Conf = conf;
        }
    }
}
