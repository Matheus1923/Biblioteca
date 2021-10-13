using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Cliente>Clientes { get; set; } 

        public DbSet<Livro> Livros { get; set; }

        public DbSet<Setor> Setors { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
