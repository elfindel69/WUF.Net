using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WUF.Net.nations;

namespace WUF.Net.Model
{
    [Table("WorldCup")]
    public class WorldCup : Cup
    {
        public WorldCup(string name, string edition, Nation host, DateTime firstDay, DateTime lastDay) : base(name, edition, host, firstDay, lastDay)
        {
        }
    }
}
