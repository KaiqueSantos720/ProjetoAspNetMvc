namespace TwoFootball.Models;
using System.ComponentModel.DataAnnotations;


public class Grupo
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nome")]
    [StringLength(1, ErrorMessage = "O campo Nome pode ter no máximo 1 caractere")]
    public String? Nome { get; set; }

    [Required(ErrorMessage = "Preencha o campo Pote 1")]
    [StringLength(50, ErrorMessage = "O campo Pote 1 pode ter no máximo 50 caracteres")]
    public String? Pote1 { get; set; }

    [Required(ErrorMessage = "Preencha o campo Pote 2")]
    [StringLength(50, ErrorMessage = "O campo Pote 2 pode ter no máximo 50 caracteres")]
    public String? Pote2 { get; set; }

    [Required(ErrorMessage = "Preencha o campo Pote 3")]
    [StringLength(50, ErrorMessage = "O campo Pote 3 pode ter no máximo 50 caracteres")]
    public String? Pote3 { get; set; }

    [Required(ErrorMessage = "Preencha o campo Pote 4")]
    [StringLength(50, ErrorMessage = "O campo Pote 4 pode ter no máximo 50 caracteres")]
    public String? Pote4 { get; set; }

    public Grupo()
    {
        
    }

    public Grupo(int id, String nome, string pote1, string pote2, string pote3, string pote4)
    {
        Id = id;
        Nome = nome;
        Pote1 = pote1;
        Pote2 = pote2;
        Pote3 = pote3;
        Pote4 = pote4;
    }
}