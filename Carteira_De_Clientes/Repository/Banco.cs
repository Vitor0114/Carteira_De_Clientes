using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Carteira_De_Clientes.Models;
using System.Data.SqlClient;
using System.Linq;

namespace Banco
{
    public class DataBase : DbContext
    {
        public DataBase() { }
        public DataBase(DbContextOptions<DataBase> options) : base(options) { }
        
        public DbSet<OrdemDeServico> OrdemDeServicos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Ordem> Ordens { get; set; }
        public DbSet<Servico> Servicos { get; set; }


        private string _connectionString = "Server=localhost;User Id=root;Database=senhas;";

    }
}