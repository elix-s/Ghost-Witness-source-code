using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Компонент назначения текста UI
/// </summary>
public class TextUIPL : MonoBehaviour
{
    /// <summary>
    /// Ключ текста UI
    /// </summary>
    public string keyTextUI;

    /// <summary>
    /// Компонент текст
    /// </summary>
    Text text;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        SetTextUI(OptionBL.Language);
        OptionBL.setLanguageEvent.AddListener(SetTextUI);
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Установить текст UI
    /// </summary>
    /// <param name="language">Язык</param>
    void SetTextUI(Language language)
    {
        try
        {
            text.text = TextUIBL.GetTextUI(language, keyTextUI);
        }
        catch
        {
            text.text = "Error";
        }
    }
}
