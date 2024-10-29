using System.Text.Json;

namespace Domain.Entities.ValueObjects;

/// <summary>
/// Базовый класс для Value Object
/// </summary>
public abstract class BaseValueObject
{
    public override bool Equals(object? obj)
    {
        if (obj is not BaseValueObject entity || entity == null)
            return false;

        var serialEntity = JsonSerializer.Serialize(entity);
        var serialThis = JsonSerializer.Serialize(this);

        if (String.CompareOrdinal(serialEntity, serialThis) != 0)
            return false;

        return true;
    }

    public override int GetHashCode()
    {
        return JsonSerializer.Serialize(this).GetHashCode();
    }
}