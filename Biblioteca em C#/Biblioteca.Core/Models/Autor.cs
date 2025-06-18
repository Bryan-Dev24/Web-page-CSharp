using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Core.Models;

public class Autor
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; } = string.Empty;

    [StringLength(1000)]
    public string Biografia { get; set; } = string.Empty;

    [Required]
    public DateTime DataNascimento { get; set; }

    public virtual ICollection<LivroAutor> Livros { get; set; } = new List<LivroAutor>();
}
