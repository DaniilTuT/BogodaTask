#nullable enable
namespace Application.Dtos.Person;

/// <summary>
/// Дто полного имени
/// </summary>
public class FullNameDto
{
    /// <summary>
    /// Имя
    /// </summary>
    public string? FirstName { get; init; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string? LastName { get; init; }

    /// <summary>
    /// Отчество
    /// </summary>
    public string? MiddleName { get; init; }
}