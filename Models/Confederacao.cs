namespace TwoFootball.Models;

public class Confederacao
{
    public int? Id { get; set; }
    public String? Nome { get; set; }
    public String? Continente { get; set; }
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