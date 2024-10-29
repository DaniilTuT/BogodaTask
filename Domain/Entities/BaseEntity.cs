using Ardalis.GuardClauses;

namespace Domain.Entities;

/// <summary>
/// Базовый класс для всех сущностей
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; private set; }
    
    protected void SetId(Guid id)
    {
        Id = Guard.Against.NullOrEmpty(id);
    }
    
    /// <summary>
    /// Переопределие метода Equals
    /// </summary>
    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        if (obj is not BaseEntity entity)
            return false;

        if (Id != entity.Id)
            return false;

        if (this.GetHashCode() != entity.GetHashCode())
        {
            return false;
        }
        
        return true;
    }

    /// <summary>
    /// Переопределение метода GetHashCode
    /// </summary>
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}