using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Core.Data;

public class BibliotecaContext : DbContext
{
    public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }

    public DbSet<Livro> Livros { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Emprestimo> Emprestimos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Livro>()
            .HasMany(l => l.Autores)
            .WithMany(a => a.Livros)
            .UsingEntity<LivroAutor>(
                j => j.HasKey(j => new { j.LivroId, j.AutorId }),
                j => j.HasOne(j => j.Autor)
                      .WithMany(a => a.Livros)
                      .HasForeignKey(j => j.AutorId),
                j => j.HasOne(j => j.Livro)
                      .WithMany(l => l.Autores)
                      .HasForeignKey(j => j.LivroId));

        modelBuilder.Entity<Emprestimo>()
            .HasOne(e => e.Usuario)
            .WithMany(u => u.Emprestimos)
            .HasForeignKey(e => e.UsuarioId);

        modelBuilder.Entity<Emprestimo>()
            .HasOne(e => e.Livro)
            .WithMany(l => l.Emprestimos)
            .HasForeignKey(e => e.LivroId);
    }
}
