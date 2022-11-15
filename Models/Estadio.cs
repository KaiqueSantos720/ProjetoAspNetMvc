namespace TwoFootball.Models;
using System.ComponentModel.DataAnnotations;


public class Estadio{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Nome")]
    [StringLength(50, ErrorMessage = "O campo Nome pode ter no máximo 50 caracteres")]
    public String? Nome { get; set; }

    [Required(ErrorMessage = "Preencha o campo Cidade")]
    [StringLength(50, ErrorMessage = "O campo Cidade pode ter no máximo 50 caracteres")]
    public String? Cidade { get; set; }

    [Required(ErrorMessage = "Preencha o campo Capacidade")]
    public int? Capacidade { get; set; }



    public Estadio(){

    }

    public Estadio(int id, String nome, String cidade, int capacidade){
        Id = id;
        Nome = nome;
        Cidade = cidade;
        Capacidade = capacidade;
    }

}