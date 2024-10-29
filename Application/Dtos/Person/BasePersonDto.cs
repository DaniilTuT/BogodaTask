using Domain.Primitives.Enums;

namespace Application.Dtos.Person;

/// <summary>
/// Базовое дто для Person
/// </summary>
public class BasePersonDto
{
    /// <summary>
    /// Полное имя
    /// </summary>
    public FullNameDto? FullName { get; init; }

    /// <summary>
    /// Гендер
    /// </summary>
    public Gender Gender { get; init; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime BirthDay { get; init; }

    /// <summary>
    /// Возраст
    /// </summary>
    public int Age => (DateTime.Now.Month - BirthDay.Month >= 0 && DateTime.Now.Day - BirthDay.Day >= 0)
        ? DateTime.Now.Year - BirthDay.Year
        : DateTime.Now.Year - BirthDay.Year - 1;


    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; init; }

    /// <summary>
    /// Никнейм в телеграм
    /// </summary>
    public string Telegram { get; init; }

    public long ChatId { get; init; }
}