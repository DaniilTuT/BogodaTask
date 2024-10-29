using FluentValidation;

namespace Domain.Validations.Validators;

/// <summary>
/// Валидация Имени
/// </summary>
public class NameValidator : AbstractValidator<string>
{
    public NameValidator(string paramName)
    {
        RuleFor(f => f)
            .NotNull().WithMessage(string.Format(ErrorMessages.NullError, paramName))
            .NotEmpty().WithMessage(string.Format(ErrorMessages.EmptyError, paramName))
            .Matches(RegexPatterns.LettersPattern).WithMessage(string.Format(ErrorMessages.OnlyLetters, paramName));
    }
}