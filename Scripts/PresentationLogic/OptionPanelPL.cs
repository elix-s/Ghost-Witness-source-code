using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Компонент отображения панели опций
/// </summary>
public class OptionPanelPL : MonoBehaviour
{
    /// <summary>
    /// Компонент рисунок
    /// </summary>
    Image m_image;

    /// <summary>
    /// Игровой объект кнопки сохранения
    /// </summary>
    GameObject saveGameButton;

    // Use this for initialization
    void Start()
    {
        m_image = GetComponent<Image>();
        saveGameButton = GameObject.Find("SaveGameButton");
        //OptionBL.setBackgroundColorEvent.AddListener(SetBackgroundColor);

        try
        {
            // Ошибка в меню нет объекта
            GameObject.Find("MainScripts").GetComponent<GameLogicBL>().setActivitySaveGameButtonEvent.AddListener(SetActivitySaveGameButton);
        }
        catch
        {
        }

        //SetBackgroundColor(OptionBL.BackgroundColor);
    }

    // Update is called once per frame
    void Update()
    {
    }

    ///// <summary>
    ///// Установить цвет фона
    ///// </summary>
    ///// <param name="backgroundColor">Цвет фона</param>
    //void SetBackgroundColor(Color backgroundColor)
    //{
    //    m_image.color = backgroundColor;
    //}

    /// <summary>
    /// Установить активность кнопки сохранения
    /// </summary>
    /// <param name="activity"></param>
    void SetActivitySaveGameButton(bool activity)
    {
        saveGameButton.SetActive(activity);
    }
}
