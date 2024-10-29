using Application.Dtos.Person;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.ValueObjects;

namespace Application.Mapping;

/// <summary>
/// Маппинг для Person
/// </summary>
public class PersonMappingProfile : Profile
{
    public PersonMappingProfile()
    {
        CreateMap<FullNameDto, FullName>();

        CreateMap<FullName, FullNameDto>();

        CreateMap<Person, PersonGetByIdResponse>()
            .ForMember(dest => dest.FullName,
                opt => opt.MapFrom(src => src.FullName));

        CreateMap<Person, PersonGetAllResponse>()
            .ForMember(dest => dest.FullName,
                opt => opt.MapFrom(src => src.FullName));

        CreateMap<Person, PersonCreateResponse>()
            .ForMember(dest => dest.FullName,
                opt => opt.MapFrom(src => src.FullName));

        CreateMap<Person, PersonUpdateResponse>()
            .ForMember(dest => dest.FullName,
                opt => opt.MapFrom(src => src.FullName));

        CreateMap<PersonCreateRequest, Person>()
            .ConstructUsing(dto => new Person(
                Guid.NewGuid(),
                new FullName(dto.FullName.FirstName, dto.FullName.LastName, dto.FullName.MiddleName),
                dto.Gender,
                dto.BirthDay,
                dto.PhoneNumber
            ));

        CreateMap<PersonUpdateRequest, Person>()
            .ConstructUsing(dto => new Person(
                dto.Id,
                new FullName(dto.FullName.FirstName, dto.FullName.LastName, dto.FullName.MiddleName),
                dto.Gender,
                dto.BirthDay,
                dto.PhoneNumber
            ));
    }
}