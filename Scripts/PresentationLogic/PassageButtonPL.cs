using UnityEngine;
using System.Collections;

/// <summary>
/// Компонент отображения кнопки перехода
/// </summary>
public class PassageButtonPL : MonoBehaviour
{
    /// <summary>
    /// Компонент логики
    /// </summary>
    GameLogicBL logicBL;

    /// <summary>
    /// Компонент отображения панели локации
    /// </summary>
    LocationPanelPL locationPanelPL;

    /// <summary>
    /// Компонент отображения панели переходов
    /// </summary>
    PassagePanelPL passagePanelPL;

    /// <summary>
    /// Компонент отображения панели параметров
    /// </summary>
    ParameterPanelPL parameterPanelPL;

    /// <summary>
    /// Индекс текущего перехода
    /// </summary>
    public int m_indexCurentPassage = -1;

    // Use this for initialization
    void Start()
    {
        logicBL = GameObject.Find("MainScripts").GetComponent<GameLogicBL>();
        locationPanelPL = GameObject.Find("LocationPanel").GetComponent<LocationPanelPL>();
        passagePanelPL = GameObject.Find("PassagePanel").GetComponent<PassagePanelPL>();
        parameterPanelPL = GameObject.Find("ParameterPanel").GetComponent<ParameterPanelPL>();
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
        logicBL.SetCurentLocation(m_indexCurentPassage);

        passagePanelPL.ClearPassagePanel();
        parameterPanelPL.ClearParameterPanel();

        locationPanelPL.ViewText();
        parameterPanelPL.GenerateViewParameterList();
    }
}
