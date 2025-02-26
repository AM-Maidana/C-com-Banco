using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityTeste
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Crud crud = new Crud();
            crud.ListarUsuarios();
            System.Console.WriteLine("---------------------");

            System.Console.WriteLine("Inserir novo usuário");
            crud.InserirUsuario(10, "Amanda", "Amanda@gmail.com");
            crud.ListarUsuarios();
            System.Console.WriteLine("---------------------");

            System.Console.WriteLine("Atualizando um usuário");
            crud.UpdateUsuario(10, "Amanda Maidana");
            crud.ListarUsuarios();
            System.Console.WriteLine("---------------------");

            System.Console.WriteLine("---------------------");
            System.Console.WriteLine("Excluindo um usuario");
            crud.DeletarUsuario(10);
            crud.ListarUsuarios();
            
        }
    }
}