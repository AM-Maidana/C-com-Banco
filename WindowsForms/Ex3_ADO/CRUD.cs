using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Instalar o pacote do NPGSQL
// dotnet add package Npgsql 
using Npgsql;

namespace ADO_FORMS
{
    public class CRUD
    {
        string conexaoSQL = "Host=localhost;Database=Conexao;Username=postgres;Password=1234";
        // A gente usar a tabela Usuario que tem as colunas id, nome e email
        public void InserirUsuario(int id, string nome, string email)
        {
            string query = "INSERT INTO Usuario (id, nome, email) VALUES (@id, @nome, @email)"; // o @ é para indicar que é um parametro

            using (NpgsqlConnection conxeao = new NpgsqlConnection(conexaoSQL))
            {
                conxeao.Open(); // Abrir a conexão, ou seja, conectar ao banco de dados
                using (NpgsqlCommand comando = new NpgsqlCommand(query, conxeao))
                {
                    comando.Parameters.AddWithValue("@id", id); // Parameters é para adicionar os parametros
                    comando.Parameters.AddWithValue("@nome", nome); // Parameters é para adicionar os parametros
                    comando.Parameters.AddWithValue("@email", email);
                    comando.ExecuteNonQuery(); // Executar o comando
                }
            }
        }

        public List<string> ListarUsuarios()
        {
            List<string> usuario = new List<string>();
            string query = "SELECT * FROM Usuario";

            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoSQL))
            {
                conexao.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    // para os valores que retornam do banco de dados
                    using (NpgsqlDataReader dr = cmd.ExecuteReader()) //
                    {
                        while (dr.Read())
                        {
                            string linha = $"ID: {dr["id"]} Nome: {dr["nome"]} Email: {dr["email"]}";
                            usuario.Add(linha); // Adiciona a linha na lista
                        }
                    }
                }
            }
            return usuario;
        }


        public void AtualizarUsuario(int id, string novoNome)
        {
            string query = "Update usuario set Nome = @Nome where id = @id"; // o @ é para indicar que é um parametro

            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoSQL))
            {
                {
                    conexao.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@Nome", novoNome);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void DeletarUsuario (int id)
        {
            string query = "DELETE FROM Usuario WHERE id = @id";

            using (NpgsqlConnection conexao = new NpgsqlConnection(conexaoSQL))
            {
                conexao.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}