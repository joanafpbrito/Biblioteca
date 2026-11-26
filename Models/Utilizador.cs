using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models;

public class Utilizador
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Display (Name = "NIF")]
    public int UserID {get;set;}
    public string Nome {get;set;} = string.Empty;

    [Display(Name = "Contacto")]
    [RegularExpression(@"^9\d{8}$", ErrorMessage = "O contacto deve ter 9 dígitos e começar por 9.")]
    public string Tel {get;set;} = string.Empty;
   
    public ICollection<Livro> Livros { get; set; } = new List<Livro>();
}
