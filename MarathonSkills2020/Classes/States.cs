using System.Collections.Generic;

/// <summary>
/// Состояния человека.
/// </summary>
public class States
{
    /// <summary>
    /// Список состояний человека.
    /// </summary>
    public static List<string> states = new List<string>();

    /// <summary>
    /// Добавление состояний человека в список.
    /// </summary>
    public static void AddingStates()
    {
        states.Add("Недостаточный вес");
        states.Add("Здоровый вес");
        states.Add("Избыточный вес");
        states.Add("Ожирение");
    }
}