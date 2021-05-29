using System.Collections.Generic;

/// <summary>
/// Класс логики текста UI
/// </summary>
public static class TextUIBL
{
    /// <summary>
    /// Словарь текстов UI
    /// </summary>
    static Dictionary<Language, Dictionary<string, string>> textUILanguageDictionary;

    /// <summary>
    /// Словарь текстов UI
    /// </summary>
    static Dictionary<Language, Dictionary<string, string>> TextUILanguageDictionary
    {
        get
        {
            if(textUILanguageDictionary == null)
            {
                textUILanguageDictionary = new Dictionary<Language, Dictionary<string, string>>();
                LoadTextUI(textUILanguageDictionary);
            }
            return textUILanguageDictionary;
        }
    }

    /// <summary>
    /// Загрузка текстов UI
    /// </summary>
    /// <param name="textUILanguageDictionary"></param>
    static void LoadTextUI(Dictionary<Language, Dictionary<string, string>> textUILanguageDictionary)
    {
        TextUIDL.LoadTextUI(textUILanguageDictionary);
    }

    /// <summary>
    /// Получить текст UI
    /// </summary>
    /// <param name="language">Язык</param>
    /// <param name="keyTextUI">Ключ текста UI</param>
    /// <returns></returns>
    public static string GetTextUI(Language language, string keyTextUI)
    {
        try
        {
            return TextUILanguageDictionary[language][keyTextUI];
        }
        catch
        {
            throw new KeyNotFoundException();
        }
    }
}
