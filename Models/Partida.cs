namespace TwoFootball.Models;
using System.ComponentModel.DataAnnotations;


public class Partida{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Preencha o campo Time da Casa")]
    [StringLength(50, ErrorMessage = "O campo Time da Casa pode ter no máximo 50 caracteres")]
    public String? TimeDaCasa { get; set; }

    [Required(ErrorMessage = "Preencha o campo Time Visitante")]
    [StringLength(50, ErrorMessage = "O campo Time Visitante pode ter no máximo 50 caracteres")]
    public String? TimeVisitante { get; set; }

    [Required(ErrorMessage = "Preencha o campo Data")]
    public DateTime? Data { get; set; }
    public Partida() 
    {

    }

    public Partida(int id, String timeDaCasa, String timeVisitante, DateTime data)
    {
        Id = id;
        TimeDaCasa = timeDaCasa;
        TimeVisitante = timeVisitante;
        Data = data;
    }
}