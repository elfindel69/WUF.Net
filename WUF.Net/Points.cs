using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.points
{
    public class Points
    {
		public double Pts1 { get; set;  }
		public double Pts2 { get; set; }

		public Points(double pts1, double pts2)
		{
			this.Pts1  =pts1;
			this.Pts2 = pts2;
		}
	}
}
