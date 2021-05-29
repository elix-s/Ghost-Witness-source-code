using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

/// <summary>
/// Компонент отображения панели переходов
/// </summary>
public class PassagePanelPL : MonoBehaviour
{
    /// <summary>
    /// Текущий список преходов на показе
    /// </summary>
    List<PassageEntity> passageViewList;

    /// <summary>
    /// Префаб кнопки
    /// </summary>
    public GameObject buttonPrefab;

    /// <summary>
    /// Список кнопок преходов
    /// </summary>
    List<GameObject> passageButtonList = new List<GameObject>();

    /// <summary>
    /// Компонент рисунок
    /// </summary>
    Image m_image;

    // Use this for initialization
    void Start()
    {
        passageViewList = GameObject.Find("MainScripts").GetComponent<GameLogicBL>().GetPassageViewList();
        m_image = transform.parent.parent.parent.GetComponent<Image>();
        GameObject.Find("LocationPanel").GetComponent<LocationPanelPL>().viewTextComplite.AddListener(GenerateViewPassageButtonList); // После окончания показа текста сгенерировать переходы
        OptionBL.setPassageTextFontSizeEvent.AddListener(SetPassageTextFontSize);
        //OptionBL.setBackgroundColorEvent.AddListener(SetBackgroundColor);
        //OptionBL.setTextColorEvent.AddListener(SetTextColor);
        //OptionBL.setButtonColorBlockEvent.AddListener(SetButtonColorBlock);
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Установить размер шрифта текста переходов
    /// </summary>
    /// <param name="passageTextFontSize">Размер шрифта текста переходов</param>
    void SetPassageTextFontSize(int passageTextFontSize)
    {
        foreach (GameObject item in passageButtonList)
        {
            Text text = item.transform.GetChild(0).GetComponent<Text>();
            text.fontSize = passageTextFontSize;
        }
    }

    ///// <summary>
    ///// Установить цвет фона
    ///// </summary>
    ///// <param name="backgroundColor">Цвет фона</param>
    //void SetBackgroundColor(Color backgroundColor)
    //{
    //    m_image.color = backgroundColor;
    //}

    ///// <summary>
    ///// Установить цвет текста
    ///// </summary>
    ///// <param name="textColor">Цвет текста</param>
    //void SetTextColor(Color textColor)
    //{
    //    foreach (GameObject item in passageButtonList)
    //    {
    //        Text text = item.transform.GetChild(0).GetComponent<Text>();
    //        text.color = textColor;
    //    }
    //}

    ///// <summary>
    ///// Установить цвет кнопок
    ///// </summary>
    ///// <param name="buttonColorBlock">Цвет кнопок</param>
    //void SetButtonColorBlock(ColorBlock buttonColorBlock)
    //{
    //    foreach (GameObject item in passageButtonList)
    //    {
    //        Button button = item.GetComponent<Button>();
    //        button.colors = buttonColorBlock;
    //    }
    //}

    /// <summary>
    /// Сгенерировать и показать список переходов
    /// </summary>
    public void GenerateViewPassageButtonList()
    {
        for (int i = 0; i < passageViewList.Count; i++)
        {
            GameObject passageGameObject = Instantiate(buttonPrefab);
            passageGameObject.transform.SetParent(transform, false);
            Text text = passageGameObject.transform.GetChild(0).GetComponent<Text>();
            text.text = passageViewList[i].Text;
            text.fontSize = OptionBL.PassageTextFontSize;
            //text.color = OptionBL.TextColor;
            //passageGameObject.GetComponent<Button>().colors = OptionBL.ButtonColorBlock;
            passageGameObject.GetComponent<PassageButtonPL>().m_indexCurentPassage = i;

            passageButtonList.Add(passageGameObject);
        }
    }

    /// <summary>
    /// Очистить панель переходов
    /// </summary>
    public void ClearPassagePanel()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

        passageButtonList.Clear();
    }
}
