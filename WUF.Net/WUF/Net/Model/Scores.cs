using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.scores
{
    public class Scores
    {
		public int Score1 { get; set; }
		public int Score2 { get; set; }

		public Scores(int score1, int score2)
		{
			this.Score1 = score1;
			this.Score2 = score2;
		}
	}
}
