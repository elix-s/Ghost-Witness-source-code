using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FontSizeSliderOptionPL : MonoBehaviour
{
    /// <summary>
    /// Компонент слайдер размера шрифта
    /// </summary>
    Slider fontSizeslider;

    /// <summary>
    /// Компонент Text у ExampleText
    /// </summary>
    Text textExampleText;

    /// <summary>
    /// Компонент Text у ExampleFontSizeText
    /// </summary>
    Text textExampleFontSizeText;

    // Use this for initialization
    void Start()
    {
        fontSizeslider = GetComponent<Slider>();
        textExampleText = GameObject.Find("ExampleText").GetComponent<Text>();
        textExampleFontSizeText = GameObject.Find("ExampleFontSizeText").GetComponent<Text>();

        fontSizeslider.value = OptionBL.LocationTextFontSize;
        textExampleText.fontSize = OptionBL.LocationTextFontSize;
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Установить в опциях размер шрифта
    /// </summary>
    public void SetFontSizeOption()
    {
        OptionBL.LocationTextFontSize = (int)fontSizeslider.value;
        OptionBL.PassageTextFontSize = (int)fontSizeslider.value;
        OptionBL.ParameterTextFontSize = (int)fontSizeslider.value;
        textExampleText.fontSize = (int)fontSizeslider.value;
        textExampleFontSizeText.text = ((int)fontSizeslider.value).ToString();
    }
}
