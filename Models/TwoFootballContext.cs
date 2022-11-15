using Microsoft.EntityFrameworkCore;

namespace TwoFootball.Models;

public class TwoFootballContext : DbContext
{
    public DbSet<Confederacao>? Confederacao { get; set; }
    public DbSet<Grupo>? Grupo { get; set; }
    
    public TwoFootballContext(DbContextOptions<TwoFootballContext> options) : base(options)
    {
        
    }
}