using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.nations;

namespace WUF.Net.Model
{
    public abstract class Cup
    {
        public string Name { get; set; }
        public string Edition { get; set; }
        public nations.Nation Host { get; set; }

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
