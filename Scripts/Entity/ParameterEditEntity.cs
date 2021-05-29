using UnityEngine;
using System.Collections;

/// <summary>
/// Перечисление редактирования видимости
/// </summary>
public enum VisibleEdit
{
    /// <summary>
    /// Оставить без изменения
    /// </summary>
    Let,

    /// <summary>
    /// Показать параметр
    /// </summary>
    Show,

    /// <summary>
    /// Скрыть параметр
    /// </summary>
    Hide
}

/// <summary>
/// Перечисление действий над значением
/// </summary>
public enum ValueEditAction
{
    /// <summary>
    /// Присвоить значению
    /// </summary>
    Equally,

    /// <summary>
    /// Прибавить к значению
    /// </summary>
    Plus,

    /// <summary>
    /// Отнять от значения
    /// </summary>
    Minus
}

/// <summary>
/// Сущность редактирования параметра
/// </summary>
public class ParameterEditEntity
{
    /// <summary>
    /// Индекс параметра
    /// </summary>
    public int IndexParameter { get; set; }

    /// <summary>
    /// Старт обязательного диапазона
    /// </summary>
    public int StartMustRangeValue { get; set; }

    /// <summary>
    /// Стоп обязательного диапазона
    /// </summary>
    public int StopMustRangeValue { get; set; }

    /// <summary>
    /// Величина изменения значения
    /// </summary>
    public int ValueEdit { get; set; }

    /// <summary>
    /// Действие над значением
    /// </summary>
    public ValueEditAction ValueEditAction { get; set; }

    /// <summary>
    /// Изменение видимости
    /// </summary>
    public VisibleEdit VisibleEdit { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public ParameterEditEntity()
    {
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="indexParameter">Индекс параметра</param>
    /// <param name="startMustRangeValue">Старт обязательного диапазона</param>
    /// <param name="stopMustRangeValue">Стоп обязательного диапазона</param>
    /// <param name="valueEdit">Величина изменения значения</param>
    /// <param name="valueEditAction">Действие над значением</param>
    /// <param name="visibleEdit">Изменение видимости</param>
    public ParameterEditEntity(int indexParameter, int startMustRangeValue, int stopMustRangeValue, int valueEdit, ValueEditAction valueEditAction, VisibleEdit visibleEdit)
    {
        IndexParameter = indexParameter;
        StartMustRangeValue = startMustRangeValue;
        StopMustRangeValue = stopMustRangeValue;
        ValueEdit = valueEdit;
        ValueEditAction = valueEditAction;
        VisibleEdit = visibleEdit;
    }
}
