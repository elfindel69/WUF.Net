using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace WUF.Net.nations
{
    class ContNation
    {
        internal static List<string> GetNatNames(MySqlConnection conn, int id)
        {
            List<string> lRes = new List<string>();
            string sql = "select name from wuf_data.nation where conf_id = @id order by name";

            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand();

            // Établissez la connexion de la commande.
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        lRes.Add(name);
                    }
                }
            }

            return lRes;
        }

        internal static List<Nation> GetNatData(MySqlConnection conn, string nation)
        {
            List<Nation> lRes = new List<Nation>();
            string sql = "select * from wuf_data.nation where name = @name";

            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand();

            // Établissez la connexion de la commande.
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", nation);
            cmd.Prepare();


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        double pts = reader.GetDouble(2);
                        string stadium = reader.GetString(4);
                        string dom = reader.GetString(5);
                        int rWuf = reader.GetInt32(6);
                        int rConf = reader.GetInt32(7);
                        lRes.Add(new Nation(id, name, pts,null, stadium, dom, rWuf,rConf));
                    }
                }
            }

            return lRes;
        }

        internal static int InsertNation(MySqlConnection conn, Nation newNat)
        {
            string sql = "insert into wuf_data.nation () values (null,@name,@pts,@conf_id,@stadium,@dom,@rWuf,@rConf)";

            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand();

            // Établissez la connexion de la commande.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 100).Value = newNat.Name;
            cmd.Parameters.Add("@pts", MySqlDbType.Double).Value = newNat.Pts;
            cmd.Parameters.Add("@conf_id", MySqlDbType.Int32).Value = newNat.Conf.ConfId;
            cmd.Parameters.Add("@stadium", MySqlDbType.VarChar, 200).Value = newNat.Stadium;
            cmd.Parameters.Add("@dom", MySqlDbType.Year).Value = newNat.DoA;
            cmd.Parameters.Add("@rWuf", MySqlDbType.Int32).Value = newNat.RWuf;
            cmd.Parameters.Add("@rConf", MySqlDbType.Int32).Value = newNat.RConf;

            int res = cmd.ExecuteNonQuery();

            return res;
        }
    }
}
