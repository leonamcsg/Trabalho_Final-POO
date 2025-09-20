using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trab_final_Gestao_Estufas.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace trab_final_Gestao_Estufas
{
    internal class ControleIrrigacao
    {
        public void AdicionarIrrigacao(EventoIrrigacao irrigacao)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var command = new NpgsqlCommand("INSERT INTO tb_eventos_irrigacao (estufa_id, data_hora, duracao_segundos) VALUES (@estufaId, @dataHora, @duracao)", connection);
                command.Parameters.AddWithValue("dataHora", irrigacao.DataHora);
                command.Parameters.AddWithValue("duracao", irrigacao.DuracaoSegundos);
                command.Parameters.AddWithValue("estufaId", irrigacao.IdEstufa);
                command.ExecuteNonQuery();

                connection.Close();
                connection.Dispose();
            }
        }
        public List<EventoIrrigacao> ObterIrrigacoes()
        {
            var irrigacoes = new List<EventoIrrigacao>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT * FROM tb_eventos_irrigacao", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var irrigacao = new EventoIrrigacao
                        {
                            IdEvento = reader.GetInt32(0),
                            IdEstufa = reader.GetInt32(1),
                            DataHora = reader.GetDateTime(2),
                            DuracaoSegundos = reader.GetInt32(3)
                            
                        };
                        irrigacoes.Add(irrigacao);
                    }
                }
                connection.Close();
                connection.Dispose();
            }
            return irrigacoes;
        }

        public void inserirIrrigacao(EventoIrrigacao irrigacao)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string sql = "INSERT INTO tb_eventos_irrigacao (id_estufa, data_hora, duracao_segundos) VALUES (@id_estufa, @data_hora, @duracao_segundos)";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("id_estufa", irrigacao.IdEstufa);
                    cmd.Parameters.AddWithValue("data_hora", irrigacao.DataHora);
                    cmd.Parameters.AddWithValue("duracao_segundos", irrigacao.DuracaoSegundos);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                con.Dispose();
            }
        }
    }
}
