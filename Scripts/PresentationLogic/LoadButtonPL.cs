using UnityEngine;
using System.Collections;

/// <summary>
/// Компонент кнопки загрузки
/// </summary>
public class LoadButtonPL : MonoBehaviour
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
    /// Компонент анимации открытия и закрытия панели
    /// </summary>
    OpenClosePanelAnimatorController openClosePanelAnimatorController;

    // Use this for initialization
    void Start()
    {
        logicBL = GameObject.Find("MainScripts").GetComponent<GameLogicBL>();
        locationPanelPL = GameObject.Find("LocationPanel").GetComponent<LocationPanelPL>();
        passagePanelPL = GameObject.Find("PassagePanel").GetComponent<PassagePanelPL>();
        parameterPanelPL = GameObject.Find("ParameterPanel").GetComponent<ParameterPanelPL>();
        openClosePanelAnimatorController = GameObject.Find("OptionPanel").GetComponent<OpenClosePanelAnimatorController>();
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
        logicBL.LoadGame();

        passagePanelPL.ClearPassagePanel();
        parameterPanelPL.ClearParameterPanel();

        locationPanelPL.ViewText();
        parameterPanelPL.GenerateViewParameterList();

        openClosePanelAnimatorController.OpenClosePanel();
    }
}
