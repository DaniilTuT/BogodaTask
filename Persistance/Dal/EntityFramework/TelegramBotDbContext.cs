using Domain.Entities;
using Persistance.Dal.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistance.Dal.EntityFramework;

/// <summary>
/// Контекст базы данных
/// </summary>
public class TelegramBotDbContext : DbContext
{
    public DbSet<Person> persons { get; init; }

    public TelegramBotDbContext(DbContextOptions<TelegramBotDbContext> options, IConfiguration configuration) :
        base(options)
    {
    }

    /// <summary>
    /// Метод применения конфигураций
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new PersonConfiguration());
    }
}