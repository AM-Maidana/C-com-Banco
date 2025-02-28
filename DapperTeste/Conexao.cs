using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

// Para usar o Dapper, é necessário instalar o pacote Dapper

namespace DapperTeste
{
    public class Conexao
    {
        private static readonly string ConexaoBD = "Host=localhost;Database=Conexao;Username=postgres;Password=1234";

        public static IDbConnection GetConexao() 
        {
            return new NpgsqlConnection(ConexaoBD);
        }
    }
}