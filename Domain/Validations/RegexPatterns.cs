using System.Text.RegularExpressions;

namespace Domain.Validations;

/// <summary>
/// Класс для описания регулярных выражений
/// </summary>
public static class RegexPatterns
{
    /// <summary>
    /// Номер телефона
    /// </summary>
    public static readonly Regex PhonePattern = new(@"[+]{1}37377[4-9]{1}[0-9]{5}$");

    /// <summary>
    /// Никнейм телеграма
    /// </summary>
    public static readonly Regex TelegramPattern = new(@"^@\S+");

    /// <summary>
    /// Строка (только буквы)
    /// </summary>
    public static readonly Regex LettersPattern = new(@"[A-Za-zА-Яа-я]+");
}