using FluentValidation;

namespace Domain.Validations.Validators;

/// <summary>
/// Валидация дня рождения
/// </summary>
public class BirthDayValidator : AbstractValidator<DateTime>
{
    public BirthDayValidator(string paramName)
    {
        RuleFor(d => d)
            .NotEmpty().WithMessage(string.Format(ErrorMessages.EmptyError, paramName))
            .LessThan(DateTime.Now).WithMessage(string.Format(ErrorMessages.FutureDate, paramName))
            .GreaterThan(DateTime.Now.AddYears(-150)).WithMessage(string.Format(ErrorMessages.OldDate, paramName));
    }
}