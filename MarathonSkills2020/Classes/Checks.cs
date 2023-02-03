using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;

/// <summary>
/// Проверки.
/// </summary>
public class Checks
{
    /// <summary>
    /// Проверка роста.
    /// </summary>
    /// <param name="value">Рост.</param>
    public static void CheckingGrowth(int value)
    {
        if (value <= 0 || value >= 300)
        {
            MessageBox.Show("Серьёзно?", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    /// <summary>
    /// Проверка веса.
    /// </summary>
    /// <param name="value">Вес.</param>
    public static void CheckingWeight(int value)
    {
        if (value <= 0 || value >= 500)
        {
            MessageBox.Show("Серьёзно?", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    /// <summary>
    /// Проверка возраста.
    /// </summary>
    /// <param name="value">Возраст.</param>
    public static void CheckingAge(int value)
    {
        if (value <= 0 || value >= 100)
        {
            MessageBox.Show("Серьёзно?", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    /// <summary>
    /// Проверка суммы.
    /// </summary>
    /// <param name="value">Сумма.</param>
    public static void CheckingAmount(int value)
    {
        if (value <= 0)
        {
            MessageBox.Show("Серьёзно?", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    /// <summary>
    /// Проверка месяца.
    /// </summary>
    /// <param name="value">Месяц.</param>
    /// <returns></returns>
    public static bool CheckingMonth(int value)
    {
        if (value <= 0 || value > 12)
        {
            MessageBox.Show("Серьёзно?", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            return false;
        }
        else
        {
            return true;
        }
    }

    /// <summary>
    /// Проверка года.
    /// </summary>
    /// <param name="value">Год.</param>
    /// <returns></returns>
    public static bool CheckingYear(int value)
    {
        if (value <= 1900 || value >= 2100)
        {
            MessageBox.Show("Серьёзно?", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            return false;
        }
        else
        {
            return true;
        }
    }

    /// <summary>
    /// Проверка валидности адреса почты.
    /// </summary>
    /// <param name="email">Почта.</param>
    /// <returns></returns>
    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        try
        {
            email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

            string DomainMapper(Match match)
            {
                var idn = new IdnMapping();
                var domainName = idn.GetAscii(match.Groups[2].Value);
                return match.Groups[1].Value + domainName;
            }
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
        catch (ArgumentException)
        {
            return false;
        }

        try
        {
            return Regex.IsMatch(email,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }

    /// <summary>
    /// Проверка валидности пароля.
    /// </summary>
    /// <param name="password">Пароль.</param>
    /// <returns></returns>
    public static bool IsValidPassword(string password)
    {
        string pattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^])[a-zA-Z0-9!@#$%^]{6,20}$";

        if (string.IsNullOrWhiteSpace(password))
        {
            return false;
        }

        try
        {
            return Regex.IsMatch(password, pattern, RegexOptions.Singleline, TimeSpan.FromMilliseconds(250));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }
}
