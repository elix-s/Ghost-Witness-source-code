using System;

/// <summary>
/// Cхема видимостей диапазона
/// </summary>
[Serializable]
public class VisiblesRangeEntity
{
    /// <summary>
    /// Стартовое значение диапозона видимости
    /// </summary>
    public int StartRangeVisibleValue { get; set; }

    /// <summary>
    /// Стоповое значение диапозона видимости
    /// </summary>
    public int StopRangeVisibleValue { get; set; }

    /// <summary>
    /// Текст диапозона
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="startRangeVisibleValue">Стартовое значение диапозона видимости</param>
    /// <param name="stopRangeVisibleValue">Стоповое значение диапозона видимости</param>
    /// <param name="text">Текст диапозона</param>
    public VisiblesRangeEntity(int startRangeVisibleValue, int stopRangeVisibleValue, string text)
    {
        StartRangeVisibleValue = startRangeVisibleValue;
        StopRangeVisibleValue = stopRangeVisibleValue;
        Text = text;
    }
}
