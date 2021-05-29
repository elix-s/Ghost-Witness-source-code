using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Cхема перехода
/// </summary>
public class PassageEntity
{
    /// <summary>
    /// Текст перехода
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Индекс следующей локации
    /// </summary>
    public int NextIndexLocation { get; set; }

    /// <summary>
    /// Номер группы перехода
    /// </summary>
    public int Group { get; set; }

    /// <summary>
    /// Список редактируемых параметров
    /// </summary>
    public List<ParameterEditEntity> parameterEditList = new List<ParameterEditEntity>();

    /// <summary>
    /// Конструктор
    /// </summary>
    public PassageEntity()
    {
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="text">Текст перехода</param>
    /// <param name="nextIndexLocation">Индекс следующей локации</param>
    /// <param name="group">Номер группы перехода</param>
    public PassageEntity(string text, int nextIndexLocation, int group)
    {
        Text = text;
        NextIndexLocation = nextIndexLocation;
        Group = group;
    }
}
