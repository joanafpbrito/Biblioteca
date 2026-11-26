using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext (DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<Biblioteca.Models.Utilizador> Utilizador { get; set; } = default!;
        public DbSet<Biblioteca.Models.Livro> Livro { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .HasOne(l => l.Utilizador)
                .WithMany(u => u.Livros)
                .HasForeignKey(l => l.UserID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
