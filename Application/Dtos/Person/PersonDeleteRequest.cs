namespace Application.Dtos.Person;

/// <summary>
/// Дто запрос удаления сущности Person
/// </summary>
public class PersonDeleteRequest
{
    public Guid Id { get; init; }
}