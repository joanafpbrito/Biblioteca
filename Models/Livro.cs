using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models;

public class Livro
{
    public int LivroID {get;set;}

    [Display (Name = "Título")]
    public string Titulo {get;set;} = string.Empty;
    public string Autor {get;set;} = string.Empty;

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Display (Name = "Data de Lançamento")]
    public DateTime DataLancamento {get;set;}

    [Display(Name = "Utilizador")]
    public int? UserID { get; set; }
    public Utilizador? Utilizador { get; set; }

}
