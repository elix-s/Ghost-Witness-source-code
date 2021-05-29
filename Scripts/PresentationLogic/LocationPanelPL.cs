using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

/// <summary>
/// Компонент отображения панели локации
/// </summary>
public class LocationPanelPL : MonoBehaviour
{
    /// <summary>
    /// Компонент текст
    /// </summary>
    Text m_text;

    /// <summary>
    /// Компонент рисунок
    /// </summary>
    Image m_image;

    /// <summary>
    /// Компонент логики
    /// </summary>
    GameLogicBL logicBL;

    /// <summary>
    /// Задержка пред выводом следущего символа
    /// </summary>
    public float pausePrintLetters = 0.1f;

    /// <summary>
    /// Событие что текст закончил вывод на экран
    /// </summary>
    public UnityEvent viewTextComplite = new UnityEvent();

    // Use this for initialization
    void Start()
    {
        m_text = transform.GetChild(0).GetComponent<Text>();
        m_image = transform.parent.parent.parent.GetComponent<Image>();
        logicBL = GameObject.Find("MainScripts").GetComponent<GameLogicBL>();
        OptionBL.setLocationTextFontSizeEvent.AddListener(SetLocationTextFontSize);
        //OptionBL.setTextColorEvent.AddListener(SetTextColor);
        //OptionBL.setBackgroundColorEvent.AddListener(SetBackgroundColor);

        SetLocationTextFontSize(OptionBL.LocationTextFontSize);
        //SetTextColor(OptionBL.TextColor);
        //SetBackgroundColor(OptionBL.BackgroundColor);

        ViewText();
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Установить размер шрифта текста локаций
    /// </summary>
    /// <param name="locationTextFontSize">Размер шрифта текста локаций</param>
    void SetLocationTextFontSize(int locationTextFontSize)
    {
        m_text.fontSize = locationTextFontSize;
    }

    ///// <summary>
    ///// Установить цвет текста
    ///// </summary>
    ///// <param name="textColor">Цвет текста</param>
    //void SetTextColor(Color textColor)
    //{
    //    m_text.color = textColor;
    //}

    ///// <summary>
    ///// Установить цвет фона
    ///// </summary>
    ///// <param name="backgroundColor">Цвет фона</param>
    //void SetBackgroundColor(Color backgroundColor)
    //{
    //    m_image.color = backgroundColor;
    //}

    /// <summary>
    /// Показать текст
    /// </summary>
    public void ViewText()
    {
        StartCoroutine(TypeLetters(logicBL.GetLocationText()));
    }

    /// <summary>
    /// Посимвольно выводить текст на экран
    /// </summary>
    /// <param name="text">Текст</param>
    /// <returns></returns>
    IEnumerator TypeLetters(string text)
    {
        if (!text.Equals(""))
        {
            m_text.enabled = true;
            m_text.text = null;
            yield return new WaitForEndOfFrame();

            if (pausePrintLetters <= 0)
            {
                m_text.text = text;
            }
            else
            {
                // Iterate over each letter
                foreach (char letter in text.ToCharArray())
                {
                    m_text.text += letter; // Add a single character to the GUI text
                    yield return new WaitForSeconds(pausePrintLetters);
                }
            }
        }
        else
        {
            m_text.enabled = false;
        }

        viewTextComplite.Invoke();
    }
}
