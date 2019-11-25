using Microsoft.EntityFrameworkCore;
using MinhaAppVS.Modulos.Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAppVS.Modulos.Vendas.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {

        }


        public DbSet<Aluno> Alunos { get; set; }


    }
}
