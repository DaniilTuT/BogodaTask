namespace Application.Dtos.Person;

/// <summary>
/// Дто запрос обновления сущности Person
/// </summary>
public class PersonUpdateRequest : BasePersonDto
{
    public Guid Id { get; init; }
}