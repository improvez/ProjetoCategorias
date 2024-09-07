using System;
using Microsoft.EntityFrameworkCore;

namespace ProjetoCategorias.Models
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(
            DbContextOptions options
        ) : base( options ) 
        { 

        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Item> Items { get; set; }
    }
}

//