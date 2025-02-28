using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics; // -> Avalia o tempo que foi utilizado


namespace EntityTeste
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch(); // -> Classe que representa o cronometro
            

            Crud crud = new Crud();
            crud.ListarUsuarios();
            System.Console.WriteLine("---------------------");

            sw.Start();
            System.Console.WriteLine("Inserir novo usuário");
            crud.InserirUsuario(10, "Amanda", "Amanda@gmail.com");
            sw.Stop();
            System.Console.WriteLine($"Tempo de inserção: {sw.ElapsedMilliseconds}ms");
            TimeSpan tempoInsercao = sw.Elapsed;
            crud.ListarUsuarios();
            System.Console.WriteLine("---------------------");

            System.Console.WriteLine("Atualizando um usuário");
            sw. Restart();
            crud.UpdateUsuario(10, "Amanda Maidana");
            sw.Stop();
            System.Console.WriteLine($"Tempo de atualização: {sw.ElapsedMilliseconds}ms");
            TimeSpan tempoUpdate = sw.Elapsed;

            crud.ListarUsuarios();
            System.Console.WriteLine("---------------------");
            System.Console.WriteLine("Excluindo um usuario");
            sw.Restart();
            crud.DeletarUsuario(10);
            sw.Stop();
            System.Console.WriteLine($"Tempo de exclusão: {sw.ElapsedMilliseconds}ms");
            TimeSpan tempoExclusao = sw.Elapsed;
            crud.ListarUsuarios();
            

            System.Console.WriteLine("---------------------");
            TimeSpan Total_dos_tempos = (tempoInsercao + tempoUpdate + tempoExclusao);
            System.Console.WriteLine($"Tempo total: {Total_dos_tempos.TotalMilliseconds}ms");

            System.Console.WriteLine($"a média das operações é: {Total_dos_tempos.TotalMilliseconds / 3}");
        }
    }
} 