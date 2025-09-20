using Npgsql;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using trab_final_Gestao_Estufas.Models;

namespace trab_final_Gestao_Estufas
{
    internal class LoggerAtmosferico
    {
        public List<LogAtmosferico> Listar()
        {
            var lista = new List<LogAtmosferico>();
            using (var con = Database.GetConnection())
            {
                con.Open();
                string sql = "SELECT id, estufa_id, data_hora, temperatura, umidade_ar FROM tb_logs_atmosfericos";
                using (var cmd = new NpgsqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new LogAtmosferico
                        {
                            IdLog = reader.GetInt32(0),
                            IdEstufa = reader.GetInt32(1),
                            DataHora = reader.GetDateTime(2),
                            Temperatura = reader.GetFloat(3),
                            Umidade = reader.GetFloat(4)
                        });
                    }
                }
            }
            return lista;
        }
    }
}
