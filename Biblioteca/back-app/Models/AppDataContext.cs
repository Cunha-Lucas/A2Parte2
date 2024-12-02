using Microsoft.EntityFrameworkCore;

namespace back_app.Models;

public class AppDataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Bancozao.db");
    }
}