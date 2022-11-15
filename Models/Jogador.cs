namespace TwoFootball.Models;
using System.ComponentModel.DataAnnotations;

public class Jogador{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nome")]
    [StringLength(50, ErrorMessage = "O campo Nome pode ter no máximo 50 caracteres")]
    public String? Nome { get; set; }

    [Required(ErrorMessage = "Preencha o campo Posição")]
    public String? Posicao { get; set; }

    [Required(ErrorMessage = "Preencha o campo Número")]
    [Range(1, 26, ErrorMessage = "O campo Número necessita estar no intervalo de 1 a 26")]
    public int? Numero { get; set; }

    [Required(ErrorMessage = "Preencha o campo Copas Participadas")]
    [Range(0, 5, ErrorMessage = "O campo Copas Participadas necessita estar no intervalo de 0 a 5")]
    public int? CopasParticipadas { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nacionalidade")]
    [StringLength(50, ErrorMessage = "O campo Nacionalidade pode ter no máximo 50 caracteres")]
    public String? Nacionalidade { get; set; }

    public Jogador(){

    }

    public Jogador(int id, String nome, String posicao, int numero, int copasParticipadas, String nacionalidade){
        Id = id;
        Nome = nome;
        Posicao = posicao;
        Numero = numero;
        CopasParticipadas = copasParticipadas;
        Nacionalidade = nacionalidade;
    }

}
