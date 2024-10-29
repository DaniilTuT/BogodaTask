using System.ComponentModel.DataAnnotations;
using Domain.Validations;
using Domain.Validations.Validators;

namespace Domain.Entities.ValueObjects;

/// <summary>
/// Value Object для полного имени
/// </summary>
public class FullName : BaseValueObject
{
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Отчество
    /// </summary>
    public string? MiddleName { get; set; } = null;

    /// <summary>
    /// Конструктор
    /// </summary>
    public FullName(string firstName, string lastName, string? middleName)
    {
        FirstName = new NameValidator(nameof(firstName)).ValidateWithErrors(firstName);
        LastName = new NameValidator(nameof(lastName)).ValidateWithErrors(lastName);
        if (middleName is not null)
        {
            MiddleName = new NameValidator(nameof(middleName)).ValidateWithErrors(middleName);
        }
    }

    /// <summary>
    /// Обновление FullName
    /// </summary>
    public FullName Update(string firstName, string lastName, string middleName)
    {
        if (firstName is not null)
        {
            FirstName = new NameValidator(nameof(firstName)).ValidateWithErrors(firstName);
        }

        if (lastName is not null)
        {
            LastName = new NameValidator(nameof(lastName)).ValidateWithErrors(lastName);
        }

        if (middleName is not null)
        {
            MiddleName = new NameValidator(nameof(middleName)).ValidateWithErrors(middleName);
        }

        return this;
    }

    private FullName()
    {
    }
}