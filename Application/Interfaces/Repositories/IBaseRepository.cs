using Domain.Entities;

namespace Application.Interfaces.Repositories;

/// <summary>
/// Базовый репозиторий
/// </summary>
public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    /// <summary>
    /// Получение по идентификатору
    /// </summary>
    public TEntity GetById(Guid id);

    /// <summary>
    /// Получение всего
    /// </summary>
    public List<TEntity> GetAll();

    /// <summary>
    /// Создание
    /// </summary>
    public void Create(TEntity entity);

    /// <summary>
    /// Обновление
    /// </summary>
    public bool Update(TEntity entity);

    /// <summary>
    /// Удаление
    /// </summary>
    public void Delete(TEntity entity);
}