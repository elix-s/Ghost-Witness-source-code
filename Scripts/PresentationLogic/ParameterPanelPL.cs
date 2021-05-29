using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Text;

/// <summary>
/// Компонент отображения панели параметров
/// </summary>
public class ParameterPanelPL : MonoBehaviour
{
    /// <summary>
    /// Текущий список параметров на показе
    /// </summary>
    List<string> parameterViewList;

    /// <summary>
    /// Префаб текста
    /// </summary>
    public GameObject textPrefab;

    /// <summary>
    /// Список текстов параметров
    /// </summary>
    List<GameObject> passageTextList = new List<GameObject>();

    /// <summary>
    /// Компонент рисунок
    /// </summary>
    Image m_image;

    // Use this for initialization
    void Start()
    {
        parameterViewList = GameObject.Find("MainScripts").GetComponent<GameLogicBL>().GetParameterViewList();
        m_image = transform.parent.parent.parent.GetComponent<Image>();
        OptionBL.setParameterTextFontSizeEvent.AddListener(SetParameterTextFontSize);
        //OptionBL.setBackgroundColorEvent.AddListener(SetBackgroundColor);
        //OptionBL.setTextColorEvent.AddListener(SetTextColor);
        OptionBL.setTestJornalModeEvent.AddListener(TestSetTestModeJournal);

        GenerateViewParameterList();
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Установить размер шрифта текста локаций
    /// </summary>
    /// <param name="parameterTextFontSize">Размер шрифта текста параметров</param>
    void SetParameterTextFontSize(int parameterTextFontSize)
    {
        foreach (GameObject item in passageTextList)
        {
            Text text = item.GetComponent<Text>();
            text.fontSize = parameterTextFontSize;
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
    //    foreach (GameObject item in passageTextList)
    //    {
    //        Text text = item.GetComponent<Text>();
    //        text.color = textColor;
    //    }
    //}

    /// <summary>
    /// Сгенерировать и показать список параметров
    /// </summary>
    public void GenerateViewParameterList()
    {
        try
        {
            if (parameterViewList.Count.Equals(1))
            {
                GameObject parameterGameObject = Instantiate(textPrefab);
                parameterGameObject.transform.SetParent(transform, false);
                Text text = parameterGameObject.GetComponent<Text>();
                text.text = "Журнал пуст.";
                text.fontSize = OptionBL.ParameterTextFontSize;

                passageTextList.Add(parameterGameObject);
            }
            //else
            //{
            //    GameObject parameterGameObject = Instantiate(textPrefab);
            //    parameterGameObject.transform.SetParent(transform, false);
            //    Text text = parameterGameObject.GetComponent<Text>();
            //    text.text = "Отношения с персонажами:";
            //    text.fontSize = OptionBL.ParameterTextFontSize;
            //    text.alignment = TextAnchor.MiddleCenter;

            //    passageTextList.Add(parameterGameObject);

            //    foreach (string item in parameterViewList)
            //    {
            //        parameterGameObject = Instantiate(textPrefab);
            //        parameterGameObject.transform.SetParent(transform, false);
            //        text = parameterGameObject.GetComponent<Text>();
            //        text.text = item;
            //        text.fontSize = OptionBL.ParameterTextFontSize;

            //        try
            //        {
            //            if (item.Equals("\r\nЗаписки Джимии:"))
            //            {
            //                text.alignment = TextAnchor.MiddleCenter;
            //            }
            //        }
            //        catch
            //        {
            //            Debug.LogError("GenerateViewParameterList");
            //            text.text = "Error";
            //        }

            //        passageTextList.Add(parameterGameObject);
            //    }
            //}
            else
            {
                GameObject parameterGameObject = Instantiate(textPrefab);
                parameterGameObject.transform.SetParent(transform, false);
                Text text = parameterGameObject.GetComponent<Text>();
                text.text = "Отношения с персонажами:";
                text.fontSize = OptionBL.ParameterTextFontSize;
                text.alignment = TextAnchor.MiddleCenter;

                passageTextList.Add(parameterGameObject);

                StringBuilder stringBuilder = new StringBuilder();

                foreach (string item in parameterViewList)
                {
                    if (item.StartsWith("\r\nЗаписки Джимии:"))
                    {
                        stringBuilder.Remove(stringBuilder.Length - 2, 2);
                        parameterGameObject = Instantiate(textPrefab);
                        parameterGameObject.transform.SetParent(transform, false);
                        text = parameterGameObject.GetComponent<Text>();
                        text.text = stringBuilder.ToString();
                        text.fontSize = OptionBL.ParameterTextFontSize;

                        passageTextList.Add(parameterGameObject);

                        parameterGameObject = Instantiate(textPrefab);
                        parameterGameObject.transform.SetParent(transform, false);
                        text = parameterGameObject.GetComponent<Text>();
                        text.text = item;
                        text.fontSize = OptionBL.ParameterTextFontSize;
                        text.alignment = TextAnchor.MiddleCenter;

                        passageTextList.Add(parameterGameObject);

                        stringBuilder = new StringBuilder();

                        continue;
                    }

                    stringBuilder.AppendLine(item);
                }

                stringBuilder.Remove(stringBuilder.Length - 2, 2);
                parameterGameObject = Instantiate(textPrefab);
                parameterGameObject.transform.SetParent(transform, false);
                text = parameterGameObject.GetComponent<Text>();
                text.text = stringBuilder.ToString();
                text.fontSize = OptionBL.ParameterTextFontSize;

                passageTextList.Add(parameterGameObject);
            }
        }
        catch
        {
            Debug.LogError("GenerateViewParameterList");
        }
    }

    /// <summary>
    /// Очистить панель параметров
    /// </summary>
    public void ClearParameterPanel()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

        passageTextList.Clear();
    }

    void TestSetTestModeJournal(bool testModeJournal)
    {
        GameObject.Find("MainScripts").GetComponent<GameLogicBL>().GenerateParameterTextList();
        ClearParameterPanel();
        GenerateViewParameterList();
    }
}
