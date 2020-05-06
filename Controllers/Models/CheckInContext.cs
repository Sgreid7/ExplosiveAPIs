namespace ExplosiveAPIs2.Controllers.Models
{
  public class CheckInContext : DbContext
  {
    public CheckInContext(DbContextOptions<CheckInContext> options)
                : base(options)
    {
    }

    public DbSet<CheckIn> CheckIns { get; set; }
  }
}