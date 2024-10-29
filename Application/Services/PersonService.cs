using Application.Dtos.Person;
using Application.Exceptions;
using Application.Interfaces.Repositories;
using Ardalis.GuardClauses;
using AutoMapper;
using Domain.Entities;

namespace Application.Services;

/// <summary>
/// Сервис для Person
/// </summary>
public class PersonService
{
    private readonly IPersonRepository _personRepository;
    private readonly IMapper _mapper;


    public PersonService(IPersonRepository personRepository, IMapper mapper)
    {
        _personRepository = personRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Получение Person
    /// </summary>
    public PersonGetByIdResponse GetById(Guid id)
    {
        var person = GetByIdOrThrow(id);
        return _mapper.Map<PersonGetByIdResponse>(person);
    }

    /// <summary>
    /// Получение всех Person
    /// </summary>
    public List<PersonGetAllResponse> GetAll()
    {
        var persons = _personRepository.GetAll();
        return _mapper.Map<List<PersonGetAllResponse>>(persons);
    }

    /// <summary>
    /// Создание Person
    /// </summary>
    public PersonCreateResponse Create(PersonCreateRequest personCreateRequest)
    {
        Guard.Against.Null(personCreateRequest);

        var person = _mapper.Map<Person>(personCreateRequest);
        _personRepository.Create(person);

        return _mapper.Map<PersonCreateResponse>(person);
    }

    /// <summary>
    /// Обновление Person
    /// </summary>
    public PersonUpdateResponse Update(PersonUpdateRequest personUpdateRequest)
    {
        Guard.Against.Null(personUpdateRequest);

        var person = GetByIdOrThrow(personUpdateRequest.Id);

        person.Update(
            personUpdateRequest.FullName.FirstName,
            personUpdateRequest.FullName.LastName,
            personUpdateRequest.FullName.MiddleName,
            personUpdateRequest.PhoneNumber,
            personUpdateRequest.Gender,
            personUpdateRequest.BirthDay,
            personUpdateRequest.Telegram);

        _personRepository.Update(person);

        return _mapper.Map<PersonUpdateResponse>(person);
    }

    /// <summary>
    /// Удаление Person
    /// </summary>
    public void Delete(Guid id)
    {
        var person = GetByIdOrThrow(id);
        _personRepository.Delete(person);
    }

    /// <summary>
    /// Метод проверки на наличие объекта
    /// </summary>
    private Person GetByIdOrThrow(Guid id)
    {
        var person = _personRepository.GetById(id);
        if (person == null)
        {
            throw new EntityNotFoundException<Person>(nameof(Person.Id), id.ToString());
        }

        return person;
    }
}