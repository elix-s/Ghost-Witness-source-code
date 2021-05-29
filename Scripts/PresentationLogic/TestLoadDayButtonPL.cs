using UnityEngine;
using System.Collections;

public class TestLoadDayButtonPL : MonoBehaviour
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
    /// Переход на локацию
    /// </summary>
    public int setCurentLocation = 0;

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
        logicBL.TestSetCurentLocation(setCurentLocation);

        passagePanelPL.ClearPassagePanel();
        parameterPanelPL.ClearParameterPanel();

        locationPanelPL.ViewText();
    }
}
