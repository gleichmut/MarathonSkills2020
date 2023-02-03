/// <summary>
/// Активности.
/// </summary>
public class Activities
{
    /// <summary>
    /// Уровень активности.
    /// </summary>
    public string ActivityLevel { get; set; }
    /// <summary>
    /// Описание активности.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Описание уровня активности.
    /// </summary>
    /// <param name="activityLevel">Уровень активности.</param>
    /// <param name="description">Описание активности.</param>
    public Activities(string activityLevel, string description)
    {
        this.ActivityLevel = activityLevel;
        this.Description = description;
    }

    /// <summary>
    /// Описание уровня активности.
    /// </summary>
    public Activities() { }
}