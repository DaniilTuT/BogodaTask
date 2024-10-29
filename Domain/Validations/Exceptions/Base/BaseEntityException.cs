namespace Domain.Validations.Exceptions.Base;

/// <summary>
/// Базовове исключение для сущностей
/// </summary>
public abstract class BaseEntityException : Exception
{
    protected BaseEntityException(string message) : base(message)
    {
    }
}