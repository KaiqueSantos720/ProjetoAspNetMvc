namespace TwoFootball.Models;

public class Jogador{
    public int? Id { get; set; }
    public String? Nome { get; set; }

    public String? Posicao { get; set; }

    public int? Numero { get; set; }

    public int? CopasParticipadas { get; set; }

    public String? Nacionalidade { get; set; }

    public Jogador(){

    }

    public Jogador(int id, String nome, String posicao, int numero, int copasparticipadas, String nacionalidade){
        Id = id;
        Nome = nome;
        Posicao = posicao;
        Numero = numero;
        CopasParticipadas = copasparticipadas;
        Nacionalidade = nacionalidade;

    }

}
