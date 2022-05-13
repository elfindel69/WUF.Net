using System;
using System.Collections.Generic;
using System.Linq;
using WUF.Net.nations;

namespace WUF.Net.Controller
{
    public class RankingController
    {
        public static List<Nation> Ranking(List<Nation> nations)
        {
            List<Nation> result = new List<Nation>();

            result = nations.OrderBy(o => o.Pts).Reverse().ToList<Nation>();

            return result;
        }

        public static void ViewRanking(List<Nation> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + 1 + " - " + list[i].Name + " - " + list[i].Pts);
            }
        }
    }
}