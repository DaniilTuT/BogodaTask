using Domain.Entities;
using Domain.Primitives.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Dal.EntityFramework.Configurations;

/// <summary>
/// Класс конфигурации для Person
/// </summary>
public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    /// <summary>
    /// Метод конфигурации
    /// </summary>
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasColumnName("id");
        builder.OwnsOne(p => p.FullName, fullName =>
        {
            fullName.Property(f => f.FirstName)
                .IsRequired()
                .HasColumnName("first_name");

            fullName.Property(f => f.LastName)
                .IsRequired()
                .HasColumnName("last_name");

            fullName.Property(f => f.MiddleName)
                .HasColumnName("middle_name");
        });

        builder.Property(p => p.Gender)
            .IsRequired()
            .HasDefaultValue(Gender.None)
            .HasColumnName("gender");

        builder.Property(p => p.BirthDay)
            .IsRequired()
            .HasColumnName("birth_date")
            .HasColumnType("timestamp");

        builder.Property(p => p.PhoneNumber)
            .IsRequired()
            .HasColumnName("phone_number");

    }
}