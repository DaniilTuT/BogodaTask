using FluentValidation;

namespace Domain.Validations;

/// <summary>
/// Класс расширение
/// </summary>
public static class ValidateExtensions
{
    public static T ValidateWithErrors<T>(this IValidator<T> validator, T value)
    {
        var validationResult = validator.Validate(value);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        return value;
    }
}