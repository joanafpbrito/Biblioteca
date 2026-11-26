using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Biblioteca.Data
{
    public class BibliotecaContext : IdentityDbContext<IdentityUser>
    {
        public BibliotecaContext (DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<Utilizador> Utilizador { get; set; } = default!;
        public DbSet<Livro> Livro { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<Livro>()
                .HasOne(l => l.Utilizador)
                .WithMany(u => u.Livros)
                .HasForeignKey(l => l.UserID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
