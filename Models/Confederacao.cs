namespace TwoFootball.Models;
using System.ComponentModel.DataAnnotations;


public class Confederacao
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nome")]
    [StringLength(50, ErrorMessage = "O campo Nome pode ter no máximo 50 caracteres")]
    public String? Nome { get; set; }

    [Required(ErrorMessage = "Preencha o campo Continente")]
    [StringLength(50, ErrorMessage = "O campo Continente pode ter no máximo 50 caracteres")]
    public String? Continente { get; set; }

    [Required(ErrorMessage = "Preencha o campo Vagas")]
    [Range(0, 13, ErrorMessage = "O campo Vagas necessita estar no intervalo de 0 a 13")]
    public int? Vagas { get; set; }

    public Confederacao()
    {
        
    }

    public Confederacao(int id, String nome, string continente, int vagas)
    {
        Id = id;
        Nome = nome;
        Vagas = vagas;
    }
}