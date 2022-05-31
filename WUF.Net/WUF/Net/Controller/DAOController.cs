
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFramework;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Text;
using WUF.Net.Model;
using WUF.Net.nations;

namespace WUF.Net.Controller
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class MyContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<WUFBoard> WUFBoard { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Conf> Confs { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Cup> Cups { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ConfCup> ConfCups { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ConfLeague> ConfLeagues { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<matches.Match> Matchs { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<country.Country> Country { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Nation> Nations { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<WorldCup> WorldCups { get; set; }

        public MyContext()
     : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connetionString = "server=localhost;database=wuf_net;user=root;password=alpine";
             optionsBuilder.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConfCup>()
                .HasOne<Conf>(s => s.Conference).WithMany(s => s.ConfCups).HasForeignKey(s=>s.ConfId);
            modelBuilder.Entity<Cup>()
               .HasOne<Nation>(s => s.Host);
            modelBuilder.Entity<ConfCup>()
               .HasOne<Nation>(s => s.Host);

        }
    }
    public class DAOController
    {
        private static MySqlConnection
                GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "wuf_net";
            string username = "root";
            string password = "alpine";

            return GetDBConnection(host, port, database, username, password);
        }

       
    }
}
