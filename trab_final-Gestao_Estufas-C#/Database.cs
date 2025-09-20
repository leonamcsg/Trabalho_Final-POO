using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Npgsql;

namespace trab_final_Gestao_Estufas
{
    public class Database
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=210800;Database=trab_final-Gestao_Estufas;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}

