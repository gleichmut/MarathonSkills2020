/// <summary>
/// Конвертер даты.
/// </summary>
public class ConverterDaysOfWeek
{
    /// <summary>
    /// Конвертер даты.
    /// </summary>
    /// <param name="dayOfWeek">День недели.</param>
    /// <returns></returns>
    public static string ConverterMethod(string dayOfWeek)
    {
        switch (dayOfWeek)
        {
            case "Monday":
                dayOfWeek = "Понедельник";
                break;

            case "Tuesday":
                dayOfWeek = "Вторник";
                break;

            case "Wednesday":
                dayOfWeek = "Среда";
                break;

            case "Thursday":
                dayOfWeek = "Четверг";
                break;

            case "Friday":
                dayOfWeek = "Пятница";
                break;

            case "Saturday":
                dayOfWeek = "Суббота";
                break;

            case "Sunday":
                dayOfWeek = "Воскресенье";
                break;
        }
        return dayOfWeek;
    }
}