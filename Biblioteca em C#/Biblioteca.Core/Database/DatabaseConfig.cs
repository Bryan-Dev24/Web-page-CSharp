using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Core.Database;

public static class DatabaseConfig
{
    public static void ConfigureDatabase(DbContextOptionsBuilder optionsBuilder, string connectionString)
    {
        optionsBuilder.UseSqlServer(connectionString);
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.EnableDetailedErrors();
    }
}
