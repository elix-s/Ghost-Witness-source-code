using System.Collections.Generic;

/// <summary>
/// Класс загрузки текста UI
/// </summary>
public static class TextUIDL
{
    /// <summary>
    /// Загрузки текста UI
    /// </summary>
    /// <param name="textUILanguageDictionary">Словарь текстов UI</param>
    public static void LoadTextUI(Dictionary<Language, Dictionary<string, string>> textUILanguageDictionary)
    {
        textUILanguageDictionary.Clear();
        
        Dictionary<string, string> textUIDictionary = new Dictionary<string, string>();
        textUIDictionary.Add("NewGameButton", "Новая игра");
        textUIDictionary.Add("LoadGameButton", "Загрузить");
        textUIDictionary.Add("ExitGameButton", "Выйти");

        textUILanguageDictionary.Add(Language.Russian, textUIDictionary);

        textUIDictionary = new Dictionary<string, string>();
        textUIDictionary.Add("NewGameButton", "New Game");
        textUIDictionary.Add("LoadGameButton", "Load");
        textUIDictionary.Add("ExitGameButton", "Exit");

        textUILanguageDictionary.Add(Language.English, textUIDictionary);
    }
}
