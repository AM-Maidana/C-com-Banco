using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DapperTeste
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Crud crud = new Crud();
            System.Console.WriteLine("----- Inserindo novo usuario -----");
            sw.Start();
            crud.InserirUsuario(11, "Maria", "maria@gmail.com");
            sw.Stop();
            System.Console.WriteLine("Tempo de execução: " + sw.ElapsedMilliseconds + " ms");
            TimeSpan tempo_Insercao = sw.Elapsed;

            System.Console.WriteLine("");
            System.Console.WriteLine("----- Alterando usuario -----");
            sw.Restart();
            crud.UpdateUsuario(11, "Maria Cláudia");
            sw.Stop();
            System.Console.WriteLine("Tempo de execução: " + sw.ElapsedMilliseconds + " ms");
            TimeSpan tempo_Update = sw.Elapsed;

            System.Console.WriteLine("");
            System.Console.WriteLine("----- Listando os usuarios -----");
            sw.Restart();
            crud.ListarUsuario();
            sw.Stop();
            System.Console.WriteLine("Tempo de execução: " + sw.ElapsedMilliseconds + " ms");
            TimeSpan tempo_Listar = sw.Elapsed;

            System.Console.WriteLine("");
            System.Console.WriteLine("----- Excluindo usuario -----");
            sw.Restart();
            crud.DeleteUsuario(11);
            sw.Stop();
            System.Console.WriteLine("Tempo de execução: " + sw.ElapsedMilliseconds + " ms");
            TimeSpan tempo_Delete = sw.Elapsed;

            System.Console.WriteLine("");
            System.Console.WriteLine("---------------------");
            TimeSpan Total_dos_tempos = (tempo_Insercao + tempo_Update + tempo_Listar + tempo_Delete);
            System.Console.WriteLine($"Tempo total das operações: {Total_dos_tempos.TotalMilliseconds}ms");
            System.Console.WriteLine($"a média dos tempos é: {Total_dos_tempos.TotalMilliseconds / 4}");
        }
    }
}
