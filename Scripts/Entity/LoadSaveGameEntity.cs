using System;
using System.Collections.Generic;

/// <summary>
/// Cхема для сохранения и загрузки игры
/// </summary>
[Serializable]
public class LoadSaveGameEntity
{
    /// <summary>
    /// Индекс текущей локации
    /// </summary>
    public int IndexCurentLocation { get; set; }

    /// <summary>
    /// Список параметров
    /// </summary>
    public List<ParameterEntity> parameterList { get; set; }
}
