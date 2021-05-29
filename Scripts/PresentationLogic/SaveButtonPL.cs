using UnityEngine;
using System.Collections;

/// <summary>
/// Компонент кнопки сохранения
/// </summary>
public class SaveButtonPL : MonoBehaviour
{
    /// <summary>
    /// Компонент логики
    /// </summary>
    GameLogicBL logicBL;

    // Use this for initialization
    void Start()
    {
        logicBL = GameObject.Find("MainScripts").GetComponent<GameLogicBL>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Обработчик события OnClick
    /// </summary>
    public void OnClick()
    {
        logicBL.SaveGame();
    }
}
