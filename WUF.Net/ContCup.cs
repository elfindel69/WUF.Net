using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace WUF.Net.competition
{
    class ContCup
    {
        internal static List<Cup> GetCupData(MySqlConnection conn, string nation)
        {
            List<Cup> lRes = new List<Cup>();
            string sql = "select * from wuf_data.cup where nation = @nation";

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
                        int nbCups = reader.GetInt32(3);
                        string result = reader.GetString(4);
                        string year = reader.GetString(5);
                        lRes.Add(new Cup(name, nbCups, result, year));
                    }
                }
            }

            return lRes;
        }

        internal static int InsertCup(MySqlConnection conn, string nation, Cup newCup)
        {
            string sql = "insert into wuf_data.cup () values (null,@nation,@name,@nbCups,@result,@year)";

            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand();

            // Établissez la connexion de la commande.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            cmd.Parameters.Add("@nation", MySqlDbType.VarChar, 200).Value = nation;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 200).Value = newCup.Name;
            cmd.Parameters.Add("@nbCups", MySqlDbType.Int32).Value = newCup.NbCups;
            cmd.Parameters.Add("@result", MySqlDbType.VarChar, 200).Value = newCup.Result;
            cmd.Parameters.Add("@year", MySqlDbType.Year).Value = newCup.Year;
           
            int res = cmd.ExecuteNonQuery();

            return res;
        }
    }
}
