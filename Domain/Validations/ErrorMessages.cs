namespace Domain.Validations;

/// <summary>
/// Класс сообщений об ошибках
/// </summary>
public abstract class ErrorMessages
{
    /// <summary>
    /// Сообщение о некорректном формате номера телефона
    /// </summary>
    public const string PhoneFormat = "Номер телефона должен быть передан в корректном формате: +37377731225.";

    /// <summary>
    /// Сообщение о некорректном формате никнейма телеграма
    /// </summary>
    public const string TelegramFormat = "Телеграм тэг должен быть передан в корректном фомате: @SomeSimpleTag";

    /// <summary>
    /// Сообщение о некорректном формате: только буквы
    /// </summary>
    public const string OnlyLetters = "{0} должно содержать только буквы.";

    /// <summary>
    /// Сообщение о некорректной дате рождения
    /// </summary>
    public const string FutureDate = "{0} не может быть в будущем";

    /// <summary>
    /// Сообщение о некорректной дате рождения
    /// </summary>
    public const string OldDate = "{0} не может быть столь давно.";

    /// <summary>
    /// Сообщение об исключении null
    /// </summary>
    public const string NullError = "{0} является null.";

    /// <summary>
    /// Сообщение об исключении empty
    /// </summary>
    public const string EmptyError = "{0} пусто.";

    /// <summary>
    /// Сообщение об ошибке Enum
    /// </summary>
    public const string DefaultEnum = "Enum {0} не может иметь значение по умолчанию";

    /// <summary>
    /// Сообщение об ошибке не найденной сущности
    /// </summary>
    public const string NotFoundError = "Сущность {0} с свойством {1} = {2} не была найдена.";
}