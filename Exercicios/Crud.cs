using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exercicios_28FEV
{
    public class Crud
    {

        // ----- CRUD DA TABELA USUARIOS
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
        public void InserirMaquina(int id_maquina, string tipo, int velocidade, int harddisk, int placa_rede, int memoria_ram, int idusuario)
        {
            using (var db = new Conexao_Banco())
            {
                db.maquinas.Add(new Maquina { id_maquina = id_maquina, tipo = tipo, velocidade = velocidade, harddisk = harddisk, placa_rede = placa_rede, memoria_ram = memoria_ram, idusuario = idusuario });
                db.SaveChanges();
                System.Console.WriteLine("Máquina inserida!");
            }
        }
        public void UpdateMaquina(int id_maquina, int novoUsuario)
        {
            using (var db = new Conexao_Banco())
            {
                var maquina = db.maquinas.Find(id_maquina);
                if (maquina != null)
                {
                    maquina.idusuario = novoUsuario;
                    db.SaveChanges();
                    System.Console.WriteLine($"Atualizado, a máquina {id_maquina} possui um novo usuário: {maquina.idusuario}");

                }
                else
                {
                    System.Console.WriteLine("Não encontrado");
                }

            }
        }
        public void DeletarMaquina(int id_maquina)
        {
            using (var db = new Conexao_Banco())
            {
                var maquina = db.maquinas.Find(id_maquina);
                if (maquina != null)
                {
                    db.maquinas.Remove(maquina);
                    db.SaveChanges();
                    System.Console.WriteLine($"Maquina {maquina.id_maquina} foi deletado com sucesso!");
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
                var maquina = db.maquinas.ToList();
                foreach (var maq in maquina)
                {
                    // Nao vou imprimir a senha pois é senha
                    System.Console.WriteLine($"id: {usuario.idusuario} Nome: {usuario.nomeuser} Especialidade: {usuario.especialidade} Ramal: {usuario.ramal}");
                }
            }
        }


    }
}