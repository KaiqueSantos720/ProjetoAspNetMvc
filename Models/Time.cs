namespace TwoFootball.Models;
using System.ComponentModel.DataAnnotations;


public class Time
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo País")]
    [StringLength(50, ErrorMessage = "O campo País pode ter no máximo 50 caracteres")]
    public String? Pais { get; set; }

    [Required(ErrorMessage = "Preencha o campo Patrocinador")]
    public String? Patrocinador { get; set; }

    [Required(ErrorMessage = "Preencha o campo Títulos")]
    [Range(0, 5, ErrorMessage = "O campo Títulos necessita estar no intervalo de 0 a 5")]
    public int? Titulos { get; set; }

    [Required(ErrorMessage = "Preencha o campo Jogador de Destaque")]
    [StringLength(50, ErrorMessage = "O campo Jogador de Destaque pode ter no máximo 50 caracteres")]
    public String? JogadorDeDestaque { get; set; }

    public Time()
    {
        
    }

    public Time(int? id, String? pais, String? patrocinador, int? titulos, String? jogadorDeDestaque)
    {
        Id = id;
        Pais = pais;
        Patrocinador = patrocinador;
        Titulos = titulos;
        JogadorDeDestaque = jogadorDeDestaque;
    }

}