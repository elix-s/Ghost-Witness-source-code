using System;
using System.Collections.Generic;

/// <summary>
/// Cхема параметра
/// </summary>
[Serializable]
public class ParameterEntity
{
    /// <summary>
    /// Имя параметра
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Старт диапазона значений
    /// </summary>
    public int StartRangeValue { get; set; }

    /// <summary>
    /// Стоп диапазона значений
    /// </summary>
    public int StopRangeValue { get; set; }

    /// <summary>
    /// Значение параметра
    /// </summary>
    int m_value;

    /// <summary>
    /// Значение параметра
    /// </summary>
    public int Value
    {
        get
        {
            return m_value;
        }

        set
        {
            if (StartRangeValue > value)
            {
                m_value = StartRangeValue;
            }
            else if (StopRangeValue < value)
            {
                m_value = StopRangeValue;
            }
            else
            {
                m_value = value;
            }
        }
    }

    /// <summary>
    /// Видимость параметра
    /// </summary>
    public bool Visible { get; set; }

    /// <summary>
    /// Видимость при нулевом значении параметра
    /// </summary>
    public bool VisibleValueZero { get; set; }

    /// <summary>
    /// Список видимостей диапазаона
    /// </summary>
    public List<VisiblesRangeEntity> visiblesRangeList = new List<VisiblesRangeEntity>();

    /// <summary>
    /// Конструктор
    /// </summary>
    public ParameterEntity()
    {
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="name">Имя параметра</param>
    /// <param name="startRangeValue">Старт диапазона</param>
    /// <param name="stopRangeValue">Стоп диапазона</param>
    /// <param name="value">Значение параметра</param>
    /// <param name="visible">Видимость параметра</param>
    /// <param name="visibleValueZero">Видимость при нулевом значении параметра</param>
    public ParameterEntity(string name, int startRangeValue, int stopRangeValue, int value, bool visible, bool visibleValueZero)
    {
        Name = name;
        StartRangeValue = startRangeValue;
        StopRangeValue = stopRangeValue;
        Value = value;
        Visible = visible;
        VisibleValueZero = visibleValueZero;
        visiblesRangeList.Add(new VisiblesRangeEntity(startRangeValue, stopRangeValue, name + ": <>"));
    }
}
