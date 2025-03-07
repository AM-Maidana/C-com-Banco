using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore; 


namespace Exercicios_07MAR
{
    public class Crud
    {

        // ----------------- CRUD DA TABELA USUARIOS -----------------

        public void InserirUsuario(int idusuario, string senha, string nomeuser, int ramal, string especialidade)
        {
            using (var db = new Conexao_Banco())
            {
                db.usuarios.Add(new Usuarios { idusuario = idusuario, senha = senha, nomeuser = nomeuser, ramal = ramal, especialidade = especialidade });
                db.SaveChanges();
            }
        }

        public void ListarUsuarios()
        {
            using (var db = new Conexao_Banco())
            {
                var usuarios = db.usuarios.ToList();
                foreach (var usuario in usuarios)
                {
                    // Nao vou imprimir a senha pois é senha
                    System.Console.WriteLine($"id: {usuario.idusuario} Nome: {usuario.nomeuser} Especialidade: {usuario.especialidade} Ramal: {usuario.ramal}");
                }
            }
        }

        public void UpdateUsuario(int idusuario, string novoNome)
        {
            using (var db = new Conexao_Banco())
            {
                var usuario = db.usuarios.Find(idusuario);
                if (usuario != null)
                {
                    usuario.nomeuser = novoNome;
                    db.SaveChanges();
                    System.Console.WriteLine($"Usuário {usuario.nomeuser} foi inserido com sucesso!");

                }
                else
                {
                    System.Console.WriteLine("Não encontrado");
                }

            }
        }

        public void DeletarUsuario(int idusuario)
        {
            using (var db = new Conexao_Banco())
            {
                var usuario = db.usuarios.Find(idusuario);
                if (usuario != null)
                {
                    db.usuarios.Remove(usuario);
                    db.SaveChanges();
                    System.Console.WriteLine($"Usuário {usuario.idusuario} foi deletado com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Nao encontrado");
                }
            }
        }
        // ----------------- CRUD DA TABELA MAQUINA -----------------
        public void InserirMaquina(int idmaq, string tipo, int velocidade, int harddisk, int placa_rede, int memoria_ram, int idusuario)
        {
            using (var db = new Conexao_Banco())
            {
                db.maquinas.Add(new Maquinas { idmaq = idmaq, tipo = tipo, velocidade = velocidade, harddisk = harddisk, placa_rede = placa_rede, memoria_ram = memoria_ram, idusuario = idusuario });
                db.SaveChanges();
                System.Console.WriteLine("Máquina inserida!");
            }
        }
        public void UpdateMaquina(int idmaq, int novoUsuario)
        {
            using (var db = new Conexao_Banco())
            {
                var maquina = db.maquinas.Find(idmaq);
                if (maquina != null)
                {
                    maquina.idusuario = novoUsuario;
                    db.SaveChanges();
                    System.Console.WriteLine($"Atualizado, a máquina {idmaq} possui um novo usuário: {maquina.idusuario}");

                }
                else
                {
                    System.Console.WriteLine("Não encontrado");
                }

            }
        }
        public void DeletarMaquina(int idmaq)
        {
            using (var db = new Conexao_Banco())
            {
                var maquina = db.maquinas.Find(idmaq);
                if (maquina != null)
                {
                    db.maquinas.Remove(maquina);
                    db.SaveChanges();
                    System.Console.WriteLine($"Maquina {maquina.idmaq} foi deletado com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Nao encontrado");
                }
            }
        }
        public void ListarMaquinas()
        {
            using (var db = new Conexao_Banco())
            {
                var maquinas = db.maquinas.ToList();
                foreach (var maquina in maquinas)
                {
                    System.Console.WriteLine($"id: {maquina.idmaq} Tipo: {maquina.tipo} Velocidade: {maquina.velocidade} Harddisk: {maquina.harddisk} Placa de Rede: {maquina.placa_rede} Memória Ram: {maquina.memoria_ram} Usuário que a utiliza: {maquina.idusuario}");
                }
            }
        }
        // ----------------- CRUD DA TABELA SOFTWARE -----------------
        public void InserirSoftware(int idsoft, string produto, int harddisk, int memoria_ram, int maquinaId)
        {
            using (var db = new Conexao_Banco())
            {
                db.softwares.Add(new Softwares { idsoft = idsoft, produto = produto, harddisk = harddisk, memoria_ram = memoria_ram, maquinaId = maquinaId });
                db.SaveChanges();
                System.Console.WriteLine("Máquina inserida!");
            }
        }
        public void UpdateSoftware(int idsoft, int novoSoftware)
        {
            using (var db = new Conexao_Banco())
            {
                var software = db.softwares.Find(idsoft);
                if (software != null)
                {
                    software.maquinaId = novoSoftware;
                    db.SaveChanges();
                    System.Console.WriteLine($"Atualizado, o software {idsoft} está na máquina: {software.maquinaId}");

                }
                else
                {
                    System.Console.WriteLine("Não encontrado");
                }

            }
        }
        public void DeletarSoftware(int idsoft)
        {
            using (var db = new Conexao_Banco())
            {
                var software = db.softwares.Find(idsoft);
                if (software != null)
                {
                    db.softwares.Remove(software);
                    db.SaveChanges();
                    System.Console.WriteLine($"O software {software.produto} foi deletado com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Nao encontrado");
                }
            }
        }
        public void ListarSoftwares()
        {
            using (var db = new Conexao_Banco())
            {
                var softwares = db.softwares.ToList();
                foreach (var software in softwares)
                {
                    System.Console.WriteLine($"id: {software.idsoft} Produto: {software.produto} Harddisk: {software.harddisk} Memória Ram: {software.memoria_ram} Máquina em que está instalado: {software.maquinaId}");
                }
            }
        }
        // ----------------- METODOS DE BUSCA -----------------
        public void BuscarUsuario(string nomeuser)
        {
            using (var db = new Conexao_Banco())
            {
                var usuario = db.usuarios.FirstOrDefault(u => u.nomeuser == nomeuser); // Aqui usamos FirstOrDefault
                if (usuario != null)
                {
                    
                    var maquina = db.maquinas.FirstOrDefault(m => m.idusuario == usuario.idusuario);

                    System.Console.WriteLine($"Nome: {usuario.nomeuser} \nEspecialidade: {usuario.especialidade} \nRamal: {usuario.ramal}");

                    if (maquina != null)
                    {
                        System.Console.WriteLine($"Máquina: {maquina.idmaq} Tipo: {maquina.tipo}"); // Exemplo de como imprimir as informações da máquina
                    }
                    else
                    {
                        System.Console.WriteLine("Este usuário não está associado a uma máquina.");
                    }
                }
                else
                {
                    System.Console.WriteLine("Usuário não encontrado.");
                }
            }
        }

    }
}
