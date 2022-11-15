namespace TwoFootball.Models;

public class Grupo
{
    public int? Id { get; set; }
    public String? Nome { get; set; }
    public String? Pote1 { get; set; }
    public String? Pote2 { get; set; }
    public String? Pote3 { get; set; }
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