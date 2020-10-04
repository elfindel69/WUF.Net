using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace WUF.Net.matches
{
    class ContMatches
    {
		public static char[] CalcResults(List<Match> lMatches, String nation)
		{
			char[] tabRes = new char[lMatches.Count];
			char res = '0';
			int i = 0;
			foreach (Match m in lMatches)
			{
				if (m.Sc1 == m.Sc2)
				{
					res = 'N';
				}
				if (m.Nat1 == nation)
				{
					if (m.Sc1 > m.Sc2)
					{
						res = 'V';
					}
					if (m.Sc1 < m.Sc2)
					{
						res = 'D';
					}
				}
				if (m.Nat2 == nation)
				{
					if (m.Sc2 > m.Sc1)
					{
						res = 'V';
					}
					if (m.Sc2 < m.Sc1)
					{
						res = 'D';
					}
				}
				tabRes[i] = res;
				i++;
			}

			return tabRes;
		}

        internal static List<Match> GetMatchesData(MySqlConnection conn, string nation)
        {
			List<Match> lRes = new List<Match>();
			string sql = "select * from wuf_data.matches where nation_1 = @nation or nation_2 = @nation order by date_match desc limit 5";

			// Créez un objet Command.
			MySqlCommand cmd = new MySqlCommand();

			// Établissez la connexion de la commande.
			cmd.Connection = conn;
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@nation", nation);
			cmd.Prepare();


			using (DbDataReader reader = cmd.ExecuteReader())
			{
				if (reader.HasRows)
				{

					while (reader.Read())
					{
						string nat1 = reader.GetString(1);
						int sc1 = reader.GetInt32(2);
						string nat2 = reader.GetString(3);
						int sc2 = reader.GetInt32(4);
						string sDate = reader.GetString(5);
						string sTimeZone2 = reader.GetString(6);
						string sTimeZone1 = reader.GetString(7);
						DateTime date = DateTime.ParseExact(sDate, "dd/MM/yyyy HH:mm:ss",
								System.Globalization.CultureInfo.InvariantCulture);
						
						TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(sTimeZone1);
						lRes.Add(new Match(nat1, sc1, nat2, sc2,date, timeZone, sTimeZone2));
					}
				}
			}

			return lRes;
		}

		internal static int InsertMatch(MySqlConnection conn, Match newMatch)
		{
			string sql = "insert into wuf_data.matches () values (null,@nation1,@score1,@nation2,@score2,@dom,@tz1,@tz2)";

			// Créez un objet Command.
			MySqlCommand cmd = new MySqlCommand();

			// Établissez la connexion de la commande.
			cmd.Connection = conn;
			cmd.CommandText = sql;

			cmd.Parameters.Add("@nation1", MySqlDbType.VarChar, 200).Value = newMatch.Nat1;
			cmd.Parameters.Add("@score1", MySqlDbType.Int32).Value = newMatch.Sc1;
			cmd.Parameters.Add("@nation2", MySqlDbType.VarChar, 200).Value = newMatch.Nat2;
			cmd.Parameters.Add("@score2", MySqlDbType.Int32).Value = newMatch.Sc2;
			cmd.Parameters.Add("@dom", MySqlDbType.Timestamp).Value = newMatch.DoM.ToString("yyyy-MM-dd HH:mm:ss");
			cmd.Parameters.Add("@tz1", MySqlDbType.VarChar, 100).Value = newMatch.TimeZoneJava;
			cmd.Parameters.Add("@tz2", MySqlDbType.VarChar, 100).Value = newMatch.TimeZone.StandardName;

			int res = cmd.ExecuteNonQuery();

			return res;
		}
	}
}
