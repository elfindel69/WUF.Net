using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WUF.Net.nations;

namespace WUF.Net.Model
{
    [Table("ConfCup")]
    public abstract class Cup
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int CupId { get; set; }
        public string Name { get; set; }
        public string Edition { get; set; }
        [ForeignKey("Nation")]
        public int HostId { get; set; }

        public virtual nations.Nation Host { get; set; }

        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }   


        public Cup(string name, string edition, Nation host,DateTime firstDay,DateTime lastDay)
        {
            Name = name;
            Edition = edition;
            Host = host;
            FirstDay = firstDay;
            LastDay = lastDay;

        }
    }
}
