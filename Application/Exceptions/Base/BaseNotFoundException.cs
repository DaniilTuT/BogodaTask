using Domain.Validations;

namespace Application.Exceptions.Base;

/// <summary>
/// Базовое исключение о ненайденной сущнсоти.
/// </summary>
public abstract class BaseNotFoundException : Exception
{
    /// <summary>
    /// Конструктор
    /// </summary>
    protected BaseNotFoundException(string entityName, string paramName, string value)
        : base(string.Format(ErrorMessages.NotFoundError, entityName, paramName, value))
    {
    }
}