using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bibliotec.Contexts
{
        // classe que tera as informacoes do banco de dados
    public class Context : DbContext
    {
        // criar um metodo construtor
        public Context(){

        }

        public Context(DbContextOptions<Context> options) : base(options){

        }
        // OnConfiguring -> Possui a configuracao da conexao com
        //o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)


        

    
        {
            // colocar as informacoes do banco
            // As informacoes existem?
            if(!optionsBuilder.IsConfigured){
                //A string de conexao do banco de dados:
                // data source => nome do servidor do banco de dados
                // initial catalog => nome do banco de dados
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-289EKCI\\SQLEXPRESS02;
                Initial Catalog = Bibliotec_mvc ;
                User Id=sa;
                Password=123;
                Integrated Security=true;
                TrustServerCertificate = true");
            }
            base.OnConfiguring(optionsBuilder);
            
        }
    
        // as referencias das nossas tabelas no banco de dados:
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<LivroCategoria> livroCategoria { get; set; }
        public DbSet<LivroReserva> LivroReserva { get; set; }
        

    }
}