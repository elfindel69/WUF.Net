using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.nations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WUF.Net.Model
{

    [Table("ConfCup")]
    public class ConfCup : Cup
    {

        [ForeignKey("Conf")]
        public int ConfId { get; set; }
        public virtual Conf Conference { get; set; } 

        public ConfCup(string name, string edition, Nation host, DateTime firstDay, DateTime lastDay,Conf conf) : base(name, edition, host, firstDay, lastDay)
        {
            Conference = conf;
        }
    }
}
