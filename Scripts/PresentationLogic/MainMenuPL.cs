using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/// <summary>
/// Компонент меню
/// </summary>
public class MainMenuPL : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        GetComponent<SaveLoadOptionBL>().LoadOption();
        AudioManagerBL.PlayMusic(AudioKey.RiverMeditation);
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Старт новой игры
    /// </summary>
    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Загрузка игры
    /// </summary>
    public void LoadGame()
    {
        DontDestroyOnLoad(GameObject.Find("LoadGame"));
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Выход из игры
    /// </summary>
    public void ExitGame()
    {
        GetComponent<SaveLoadOptionBL>().SaveOption();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
