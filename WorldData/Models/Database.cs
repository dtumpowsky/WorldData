using System;
using MySql.Data.MySqlClient;
using WorldData;
using Microsoft.AspNetCore.Mvc;

namespace WorldData.Models
{
    public class DB
    {
        public static MySqlConnection Connection()
        {
            MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
            return conn;
        }
    }
}
