using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace EntityTeste
{
    public class Crud
    {
        public void InserirUsuario(int id, string nome, string email)
        {
            using (var db = new Conexao())
            {
                db.Usuarios.Add(new Usuarios { ID = id, Nome = nome, Email = email });
                db.SaveChanges();
            }
        }

        public void ListarUsuarios()
        {
            using (var db = new Conexao())
            {
                var usuarios = db.Usuarios.ToList(); //Aqui pega todos os registros da tabela MAS como lista
                foreach (var usuario in usuarios)
                {
                    System.Console.WriteLine($"Id: {usuario.ID} - Nome: {usuario.Nome} - Email: {usuario.Email}");
                }
            }
        }

        public void UpdateUsuario(int id, string novoNome)
        {
            using (var db = new Conexao())
            {
                var usuario = db.Usuarios.Find(id); // encontrar o id do registro que quero atualizar
                if (usuario != null)
                {
                    usuario.Nome = novoNome;
                    db.SaveChanges();
                    System.Console.WriteLine("Success!");
                }
                else
                {
                    System.Console.WriteLine("Não encontrado");
                }

            }
        }

        public void DeletarUsuario(int id)
        {
            using (var db = new Conexao())
            {
                var usuario = db.Usuarios.Find(id);
                if (usuario != null){
                db.Usuarios.Remove(usuario);
                db.SaveChanges();
                System.Console.WriteLine("Success!");
                }
                else
                {
                    System.Console.WriteLine("Nao encontrado");
                }
            }
        }
    }
}