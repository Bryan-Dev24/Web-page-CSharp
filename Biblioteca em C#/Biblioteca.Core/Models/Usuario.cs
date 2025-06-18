using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Core.Models;

public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [Phone]
    public string Telefone { get; set; } = string.Empty;

    public string Endereco { get; set; } = string.Empty;

    [Required]
    public DateTime DataCadastro { get; set; }

    public virtual ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
}
