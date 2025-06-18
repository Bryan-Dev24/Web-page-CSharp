using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Core.Models;

public class Livro
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Titulo { get; set; } = string.Empty;

    [Required]
    public string Isbn { get; set; } = string.Empty;

    [StringLength(1000)]
    public string Sinopse { get; set; } = string.Empty;

    [Required]
    public int AnoPublicacao { get; set; }

    public int Paginas { get; set; }

    public virtual ICollection<LivroAutor> Autores { get; set; } = new List<LivroAutor>();
    public virtual ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
}
