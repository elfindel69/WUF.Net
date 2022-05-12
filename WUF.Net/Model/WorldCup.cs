using System;
using System.Collections.Generic;
using System.Text;
using WUF.Net.nations;

namespace WUF.Net.Model
{
    public class WorldCup : Cup
    {
        public WorldCup(string name, string edition, Nation host, DateTime firstDay, DateTime lastDay) : base(name, edition, host, firstDay, lastDay)
        {
        }
    }
}
