using System;

/// <summary>
/// Расчеты.
/// </summary>
public class Calculating
{
    /// <summary>
    /// Уровень BMR. 
    /// </summary>
    static double bmr;
    /// <summary>
    /// Уровень BMI.
    /// </summary>
    static double bmi;
    /// <summary>
    /// Сидячая активность.
    /// </summary>
    static double sedentaryActivity;
    /// <summary>
    /// Маленькая активность.
    /// </summary>
    static double littleActivity;
    /// <summary>
    /// Средняя активность.
    /// </summary>
    static double averageActivity;
    /// <summary>
    /// Сильная активность.
    /// </summary>
    static double strongActivity;
    /// <summary>
    /// Максимальная актиность.
    /// </summary>
    static double maximumActivity;

    /// <summary>
    /// Расчет для мужчин.
    /// </summary>
    /// <param name="growth">Рост.</param>
    /// <param name="weight">Вес.</param>
    /// <param name="age">Возраст.</param>
    /// <returns></returns>
    public static double CalculateMale(int growth, int weight, int age)
    {
        bmr = Math.Round(66 + (13.7 * weight) + (5 * growth) - (6.8 * age), 3);
        return bmr;
    }

    /// <summary>
    /// Расчет для женщин.
    /// </summary>
    /// <param name="growth">Рост.</param>
    /// <param name="weight">Вес.</param>
    /// <param name="age">Возраст.</param>
    /// <returns></returns>
    public static double CalculateFemale(int growth, int weight, int age)
    {
        bmr = Math.Round(655 + (9.6 * weight) + (1.8 * growth) - (4.7 * age), 3);
        return bmr;
    }

    /// <summary>
    /// Расчет сидячей активности.
    /// </summary>
    /// <returns></returns>
    public static double SedentaryActivity()
    {
        sedentaryActivity = Math.Round(bmr * 1.2, 3);
        return sedentaryActivity;
    }

    /// <summary>
    /// Расчет маленькой актинвости.
    /// </summary>
    /// <returns></returns>
    public static double LittleActivity()
    {
        littleActivity = Math.Round(bmr * 1.375, 3);
        return littleActivity;
    }

    /// <summary>
    /// Расчет средней активности.
    /// </summary>
    /// <returns></returns>
    public static double AverageActivity()
    {
        averageActivity = Math.Round(bmr * 1.55, 3);
        return averageActivity;
    }

    /// <summary>
    /// Расчет сильной активности.
    /// </summary>
    /// <returns></returns>
    public static double StrongActivity()
    {
        strongActivity = Math.Round(bmr * 1.725, 3);
        return strongActivity;
    }

    /// <summary>
    /// Расчет максимальной активности.
    /// </summary>
    /// <returns></returns>
    public static double MaximumActivity()
    {
        maximumActivity = Math.Round(bmr * 1.9, 3);
        return maximumActivity;
    }

    /// <summary>
    /// Расчет BMI.
    /// </summary>
    /// <param name="growth">Рост.</param>
    /// <param name="weight">Вес.</param>
    /// <returns></returns>
    public static double CalculateBMI(int growth, int weight)
    {
        bmi = Math.Round(weight / Math.Pow(growth, 2) * 10000, 3);
        return bmi;
    }
}