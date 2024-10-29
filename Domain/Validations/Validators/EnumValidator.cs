using FluentValidation;

namespace Domain.Validations.Validators;

/// <summary>
/// Валидация перечислений
/// </summary>
public class EnumValidator<TEnum> : AbstractValidator<TEnum> where TEnum : Enum
{
    public EnumValidator(string paramName, params TEnum[] defaultValues)
    {
        foreach (var value in defaultValues)
        {
            RuleFor(e => e)
                .NotEqual(value).WithMessage(string.Format(ErrorMessages.DefaultEnum, paramName));
        }
    }
}