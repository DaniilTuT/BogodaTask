namespace Application.Dtos.Person;

/// <summary>
/// Дто ответ на обновление сущности Person
/// </summary>
public class PersonUpdateResponse : BasePersonDto
{
    public Guid Id { get; init; }
}