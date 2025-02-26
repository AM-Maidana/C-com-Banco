using System;

using System.Diagnostics; // -> Avalia o tempo que foi utilizado
using Npgsql;

namespace TesteConexao
{
    public class Crud
    {
        private readonly string conexao = "Host=localhost;Database=Conexao;Username=postgres;Password=1234";

        void InserirUsuario(int id, string nome, string email)
        {
            string query = "INSERT INTO public.usuarios (id, nome, email) VALUES (@id, @nome, @email)";

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        void LerUsuario()
        {
            string queryLer = "SELECT * FROM public.usuarios";

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryLer, con))
                {
                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine($"Id: {dr["id"]}, Nome: {dr["nome"]}, E-mail: {dr["email"]}");
                        }
                    }
                }
                con.Close();
            }
        }

        void AtualizarUsuario(int id, string nome, string email)
        {
            string queryUpdate = "UPDATE public.usuarios SET nome = @nome, email = @email WHERE id = @id";

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        void DeletarUsuario(int id)
        {
            string queryDelete = $"Delete from public.usuarios where id = {id}";

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void Main(string[] args)
        {
            Crud crud = new Crud();

            // medir o tempo de execução
            Stopwatch sw = new Stopwatch(); // -> Classe que representa o cronometro
            TimeSpan tempoTotal;// -> Variavel que vai armazenar o tempo da execução

            // 1. medindo o tempo de inserção      
            sw.Start(); // -> Inicia o cronometro   
            // Inserindo um usuário
            crud.InserirUsuario(8, "teste", "teste@email.com");
            sw.Stop();
            System.Console.WriteLine($"Tempo de inserção: {sw.ElapsedMilliseconds}ms");
            TimeSpan tempoInsercao = sw.Elapsed;


            // Lendo usuários cadastrados
            sw.Restart();
            crud.LerUsuario();
            sw.Stop();
            System.Console.WriteLine($"Tempo de leitura: {sw.ElapsedMilliseconds}ms");
            TimeSpan tempoLeitura = sw.Elapsed;


            // Atualizando um usuário
            sw.Restart();
            crud.AtualizarUsuario(8, "teste Silva", "teste.silva@email.com");
            sw.Stop();
            System.Console.WriteLine($"Tempo de atualização: {sw.ElapsedMilliseconds}ms");
            TimeSpan tempoAtualizacao = sw.Elapsed;


            // // Deletar usuario
            sw.Restart();
            crud.DeletarUsuario(7);
            sw.Stop();
            System.Console.WriteLine($"Tempo de exclusão: {sw.ElapsedMilliseconds}ms");
            TimeSpan tempoExclusao = sw.Elapsed;


            // // media dos tempos
            System.Console.WriteLine("============");
            TimeSpan Total_dos_tempos = (tempoInsercao + tempoLeitura + tempoAtualizacao + tempoExclusao);
            System.Console.WriteLine($"Tempo total: {Total_dos_tempos.TotalMilliseconds}ms");

            System.Console.WriteLine($"a média das operações é: {Total_dos_tempos.TotalMilliseconds / 4}");

        }
    }
}
