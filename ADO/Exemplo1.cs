using System;
using Npgsql;
/*
        DE MODO MANUAL, SEM O USO DO ENTITY FRAMEWORK, APENAS O POSTGRES
*/
namespace Exemplo1
{
    public class Executar
    {
        static void Testes (string[] args)
        {
            string conexao = "Host=localhost;Database=Conexao;Username=postgres;Password=1234";


            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                try
                {
                    con.Open();
                    System.Console.WriteLine("Conexão foi um sucesso");

//Imprimir o que há no meu banco
                    // string query = "select table_name from information_schema.tables where table_schema = 'public'";

                    /*using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                     {
                         //NpgsqlCommand ele representa um comando SQL que será executado no banco de dados
                         using (NpgsqlDataReader dr = cmd.ExecuteReader())
                         {
                             //NpgsqlDataReader representa um leitor de dados que irá ler os dados do banco
                             System.Console.WriteLine("Tabelas do banco:");
                             while (dr.Read()) // Enqto tiver dados para serem lidos
                             {
                                 System.Console.WriteLine(dr.GetString(0)); // imprime o nome da tabela, ou valor da coluna

                                 /*Exemplo se eu tivesse uma tabela de informações do usuário:

                                 ** System.Console.WriteLine(dr.GetString(0)); --> imprime o nome da tabela, ou valor da coluna 0

                                 Console.WriteLine("Id: " + dr["id"] + "Nome: " + dr["nome"] + "E-mail: " + dr["email"]);

                                 OU

                                 Console.WriteLine($"Id: {dr.GetInt32(0)} Nome: {dr.GetString(1)} E-mail: {dr.GetString(2)}");
                                 */
                    // }
                    // }
                    // }

// Vamos criar um comando que vai inserir um novo registro na tabela "usuário"
                  /*  string query = "Select * from public.usuario";

                    string insertQuery = "Insert into public.usuarios (id, nome, email) values (1, 'João', 'joao@gmail.com')";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, con))
                    {
                        int row = cmd.ExecuteNonQuery();
                        System.Console.WriteLine("Tudo certo, foi inserido");
                    }*/

// Fazendo um delete
                  /* string query = "Delete from usuarios where id = 1";

                   using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                   {
                    int row = cmd.ExecuteNonQuery();
                    System.Console.WriteLine("Tudo certo, foi deletado");
                   }*/

// Fazendo um Update
                    string query = "Update usuarios set nome = 'Fefe' where id = 2";

                    using(NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        int row = cmd.ExecuteNonQuery();
                        System.Console.WriteLine("Tudo certo, foi atualizado");
                    }
                }

                catch (NpgsqlException ex)
                {
                    System.Console.WriteLine("Erro na conexão com o banco de dados " + ex.Message);
                }
            }
        }
    }
}