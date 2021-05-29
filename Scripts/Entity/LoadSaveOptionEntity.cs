using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Cхема для сохранения и загрузки опций
/// </summary>
[Serializable]
public class LoadSaveOptionEntity
{
    ///// <summary>
    ///// Текущий язык
    ///// </summary>
    //public Language Language { get; set; }

    /// <summary>
    /// Размер шрифта текста локаций
    /// </summary>
    public int TextFontSize { get; set; }

    /// <summary>
    /// Громкость музыки
    /// </summary>
    public float MusicVolume { get; set; }
}
