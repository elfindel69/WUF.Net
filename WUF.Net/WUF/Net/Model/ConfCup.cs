using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.nations;

namespace WUF.Net.Model
{
    public class ConfCup : Cup
    {
        Conf Conf { get; set; } 

        public ConfCup(string name, string edition, Nation host, DateTime firstDay, DateTime lastDay,Conf conf) : base(name, edition, host, firstDay, lastDay)
        {
            Conf = conf;
        }
    }
}
