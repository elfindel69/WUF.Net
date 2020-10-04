using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace WUF.Net.competition
{
    class ContLeague
    {
        internal static List<League> GetLeagueData(MySqlConnection conn, string nation)
        {
            List<League> lRes = new List<League>();
            string sql = "select * from wuf_data.league where nation = @nation";

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
                        string name = reader.GetString(2);
                        string league = reader.GetString(3);
                        string result = reader.GetString(4);
                        string year = reader.GetString(5);
                        lRes.Add(new League(name, league, result, year));
                    }
                }
            }

            return lRes;
        }

        internal static int InsertLeague(MySqlConnection conn, string nation, League newLeague)
        {
            string sql = "insert into wuf_data.league () values (null,@nation,@name,@league,@result,@year)";

            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand();

            // Établissez la connexion de la commande.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            cmd.Parameters.Add("@nation", MySqlDbType.VarChar, 200).Value = nation;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 200).Value = newLeague.Name;
            cmd.Parameters.Add("@league", MySqlDbType.VarChar, 50).Value = newLeague.LLeague;
            cmd.Parameters.Add("@result", MySqlDbType.VarChar, 100).Value = newLeague.Result;
            cmd.Parameters.Add("@year", MySqlDbType.Year).Value = newLeague.Year;

            int res = cmd.ExecuteNonQuery();

            return res;
        }
    }
}
