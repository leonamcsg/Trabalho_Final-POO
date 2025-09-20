using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trab_final_Gestao_Estufas.Models;

namespace trab_final_Gestao_Estufas
{
    public class GestorEstufas
    {
        public void Inserir(Estufa estufa)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string sql = "INSERT INTO tb_estufas (nome, localizacao, tamanho_m2, cultura) VALUES (@nome, @localizacao, @tamanho_m2, @cultura)";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("nome", estufa.Nome);
                    cmd.Parameters.AddWithValue("localizacao", estufa.Localizacao);
                    cmd.Parameters.AddWithValue("tamanho_m2", estufa.Tamanho_m2);
                    cmd.Parameters.AddWithValue("cultura", estufa.Cultura);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                con.Dispose();
            }
        }

        public List<Estufa> Listar()
        {
            var lista = new List<Estufa>();
            using (var con = Database.GetConnection())
            {
                con.Open();
                string sql = "SELECT id, nome, localizacao, tamanho_m2, cultura FROM tb_estufas";
                using (var cmd = new NpgsqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Estufa
                        {
                            IdEstufa = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Localizacao = reader.GetString(2),
                            Tamanho_m2 = reader.GetInt32(3),
                            Cultura = reader.GetString(4)
                        });
                    }
                }
                con.Close();
                con.Dispose();
            }
            return lista;
        }

        public void Atualizar(Estufa estufa)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string sql = "UPDATE tb_estufas SET nome=@nome, localizacao=@localizacao, tamanho_m2=@tamanho_m2,  cultura=@cultura WHERE id=@id";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("id", estufa.IdEstufa);
                    cmd.Parameters.AddWithValue("nome", estufa.Nome);
                    cmd.Parameters.AddWithValue("localizacao", estufa.Localizacao);
                    cmd.Parameters.AddWithValue("tamanho_m2", estufa.Tamanho_m2);
                    cmd.Parameters.AddWithValue("cultura", estufa.Cultura);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                con.Dispose();
            }
        }

        public void Deletar(int id)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string sql = "DELETE FROM tb_estufas WHERE id=@id";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                con.Dispose();
            }
        }
    }
}
