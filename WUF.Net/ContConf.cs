using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace WUF.Net.nations
{
    class ContConf
    {
        public static List<string> GetConfNames(MySqlConnection conn)
        {
            List<string> lRes = new List<string>();
            string sql = "select name from wuf_data.conference";

            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand();

            // Établissez la connexion de la commande.
            cmd.Connection = conn;
            cmd.CommandText = sql;


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string conf = reader.GetString(0);
                        lRes.Add(conf);
                    }
                }
            }

            return lRes;

        }

        internal static List<Conf> GetConfData(MySqlConnection conn, string conf)
        {
            List<Conf> lRes = new List<Conf>();
            string sql = "select * from wuf_data.conference where name = @name";

            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand();

            // Établissez la connexion de la commande.
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@name", conf);
            cmd.Prepare();


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string name = reader.GetString(1);
                        string adj = reader.GetString(2);
                        int nbMembers = reader.GetInt32(3);
                        string doa = reader.GetString(4);
                        lRes.Add(new Conf(name,adj,nbMembers,doa));
                    }
                }
            }

            return lRes;
        }

        internal static int InsertConf(MySqlConnection conn, Conf newConf)
        {
            string sql = "insert into wuf_data.conference () values (null,@name,@adj,@nb,@doa)";

            // Créez un objet Command.
            MySqlCommand cmd = new MySqlCommand();

            // Établissez la connexion de la commande.
            cmd.Connection = conn;
            cmd.CommandText = sql;

            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 100).Value = newConf.Name;
            cmd.Parameters.Add("@adj", MySqlDbType.VarChar,200).Value = newConf.Adj;
            cmd.Parameters.Add("@nb", MySqlDbType.Int32).Value = newConf.NbMembers;
            cmd.Parameters.Add("@doa", MySqlDbType.Year).Value = newConf.DoF;

            int res = cmd.ExecuteNonQuery();

            return res;

        }
    }
}

