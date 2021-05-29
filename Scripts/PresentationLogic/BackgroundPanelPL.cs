using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundPanelPL : MonoBehaviour
{
    /// <summary>
    /// Компонент рисунок
    /// </summary>
    Image m_image;

    // Use this for initialization
    void Start()
    {
        m_image = GetComponent<Image>();
        //OptionBL.setBackgroundColorEvent.AddListener(SetBackgroundColor);

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
}
