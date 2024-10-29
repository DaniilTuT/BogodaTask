using Ardalis.GuardClauses;
using Domain.Entities.ValueObjects;
using Domain.Primitives.Enums;
using Domain.Validations.Validators;
using Domain.Validations;

namespace Domain.Entities;

/// <summary>
/// Сущность человека
/// </summary>
public class Person : BaseEntity
{
    /// <summary>
    /// Имя
    /// </summary>
    public FullName FullName { get; set; }

    /// <summary>
    /// Гендер
    /// </summary>
    public Gender Gender { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime BirthDay { get; set; }

    /// <summary>
    /// Возраст
    /// </summary>
    public int Age => (DateTime.Now.Month - BirthDay.Month >= 0 && DateTime.Now.Day - BirthDay.Day >= 0)
        ? DateTime.Now.Year - BirthDay.Year
        : DateTime.Now.Year - BirthDay.Year - 1;

    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; set; }


    
    /// <summary>
    /// Конструктор
    /// </summary>
    public Person(
        Guid id,
        FullName fullName,
        Gender gender,
        DateTime birthDate,
        string phoneNumber
        )
    {
        SetId(id);
        FullName = Guard.Against.Null(fullName);
        Gender = new EnumValidator<Gender>(nameof(gender), [Gender.None]).ValidateWithErrors(gender);
        BirthDay = new BirthDayValidator(nameof(birthDate)).ValidateWithErrors(birthDate);
        PhoneNumber = new PhoneNumberValidator(nameof(phoneNumber)).ValidateWithErrors(phoneNumber);
    }
    
    public Person() {}

    /// <summary>
    /// Обновление Person.
    /// </summary>
    public Person Update(
        string firstName,
        string lastName,
        string middleName,
        string phoneNumber,
        Gender gender,
        DateTime birthDate,
        string telegram)
    {
        FullName.Update(firstName, lastName, middleName);
        PhoneNumber = new PhoneNumberValidator(nameof(phoneNumber)).ValidateWithErrors(phoneNumber);
        Gender = new EnumValidator<Gender>(nameof(gender), [Gender.None]).ValidateWithErrors(gender);
        BirthDay = new BirthDayValidator(nameof(birthDate)).ValidateWithErrors(birthDate);
        return this;
    }
   
}