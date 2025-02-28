using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace DapperTeste
{
    public class Crud
    {
        public void InserirUsuario(int id, string nome, string email)
        {
            using (IDbConnection db = Conexao.GetConexao())
            {
                string query = $"INSERT INTO usuarios (id, nome, email) VALUES ('{id}', '{nome}', '{email}')"; //--> o @ referencia ao objeto
                db.Execute(query);
                System.Console.WriteLine($"Usuário {nome} foi inserido com sucesso!");

            }
        }

        public void ListarUsuario ()
        {
            using (IDbConnection db = Conexao.GetConexao())
            {
                string query = "SELECT * FROM usuarios";
                var usuarios = db.Query<Usuarios>(query).ToList();

                foreach (var usuario in usuarios)
                {
                    System.Console.WriteLine($"Id: {usuario.Id} - Nome: {usuario.Nome} - Email: {usuario.Email}");
                }
            }
        }
        public void UpdateUsuario (int id, string novoNome)
        {
            using (IDbConnection db = Conexao.GetConexao())
            {
                string query = $"UPDATE usuarios SET nome = '{novoNome}' WHERE id = {id}";
                db.Execute(query);
                System.Console.WriteLine($"Usuário {id} foi atualizado com sucesso!");
            }
        }
        public void DeleteUsuario (int id)
        {
            using (IDbConnection db = Conexao.GetConexao())
            {
                string query = $"DELETE FROM usuarios WHERE id = {id}";
                db.Execute(query);
                System.Console.WriteLine($"Usuário {id} foi deletado com sucesso!");
            }
        }
    }
}

