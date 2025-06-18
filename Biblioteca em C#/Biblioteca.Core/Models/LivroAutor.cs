using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Core.Models;

public class LivroAutor
{
    [Key]
    public int LivroId { get; set; }
    [Key]
    public int AutorId { get; set; }
}
