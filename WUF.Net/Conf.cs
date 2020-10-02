﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WUF.Net.nations
{
    public class Conf
    {
		public string Name { get; set; }
		public string Adj { get; set; }
		public int NbMembers { get; set; }
		public string DoF { get; set; }

		public Conf(String name, String adj, int nbMembers, String date)
		{
			this.Name = name;
			this.Adj = adj;
			this.NbMembers = nbMembers;
			this.DoF = date;
		}

	}
}
