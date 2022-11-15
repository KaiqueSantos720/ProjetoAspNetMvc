namespace TwoFootball.Models;

public class Estadio{
    public int? Id { get; set; }
    public String? Nome { get; set; }

    public String? Cidade { get; set; }

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