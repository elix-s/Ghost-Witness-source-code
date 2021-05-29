using System.Collections.Generic;

/// <summary>
/// Перечисление действий в локации
/// </summary>
public enum ActionLocation
{
    /// <summary>
    /// Ничего не делать
    /// </summary>
    None,

    /// <summary>
    /// Новая игра
    /// </summary>
    NewGame,

    /// <summary>
    /// Загрузить игру
    /// </summary>
    LoadGame,

    /// <summary>
    /// Выйти в главное меню
    /// </summary>
    MainMenu
}

/// <summary>
/// Cхема локации
/// </summary>
public class LocationEntity
{
    /// <summary>
    /// Текст локации
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Список переходов
    /// </summary>
    public List<PassageEntity> passageList = new List<PassageEntity>();

    /// <summary>
    /// Ключ спрайта фона панели верхнего меню
    /// </summary>
    public SpritesKey BackgroundTopMenuPanel { get; set; }

    /// <summary>
    /// Ключ спрайта персонажа панели верхнего меню
    /// </summary>
    public SpritesKey PersonTopMenuPanel { get; set; }

    /// <summary>
    /// Ключ музыки в локации
    /// </summary>
    public AudioKey MusicLocation { get; set; }

    /// <summary>
    /// Действие в локации
    /// </summary>
    public ActionLocation ActionLocation { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public LocationEntity()
    {
    }
}
