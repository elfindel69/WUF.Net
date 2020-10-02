using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.utils
{
    public class MyRandom
    {
		public static int RNG5(Random rand, int rng)
		{
			return rand.Next(200) * rng * 5;
		}
		public static int RNG2(Random rand, int rng)
		{
			return rand.Next(200) * rng * 2;
		}
	}
}
