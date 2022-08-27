using Microsoft.EntityFrameworkCore;

public class Context:DbContext
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder db)
    {
        db.UseSqlServer("data source=.;initial catalog=DbQuestionnaire1;integrated security=true");
    }
}