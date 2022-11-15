namespace TwoFootball.Models;

public class Time
{
    public int? Id { get; set; }
    public String? Pais { get; set; }
    public String? Patrocinador { get; set; }
    public int? Titulos { get; set; }
    public String? JogadorDeDestaque { get; set; }
    public String? Confederacao { get; set; }

    public Time()
    {
        
    }

    public Time(int? id, String? pais, String? patrocinador, int? titulos, String? jogadorDeDestaque, String? confederacao)
    {
        Id = id;
        Pais = pais;
        Patrocinador = patrocinador;
        Titulos = titulos;
        JogadorDeDestaque = jogadorDeDestaque;
        Confederacao = confederacao;
    }

}