namespace TwoFootball.Models;

public class Partida{
    public int? Id { get; set; }
    public String? TimeDaCasa { get; set; }
    public String? TimeVisitante { get; set; }
    public String? Estadio { get; set; }
    public DateTime? Data { get; set; }
    public Partida() 
    {

    }

    public Partida(int id, String timeDaCasa, String timeVisitante, String estadio, DateTime data)
    {
        Id = id;
        TimeDaCasa = timeDaCasa;
        TimeVisitante = timeVisitante;
        Estadio = estadio;
        Data = data;
    }
}