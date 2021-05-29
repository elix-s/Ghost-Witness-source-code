using UnityEngine;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine.Events;

/// <summary>
/// Cхема события установки спрайтов на панель верхнего меню
/// </summary>
public class SetSpritesTopMenuPanelEvent : UnityEvent<Sprite, Sprite>
{
}

/// <summary>
/// Cхема события установки активности кнопки сохранения
/// </summary>
public class SetActivitySaveGameButtonEvent : UnityEvent<bool>
{
}

/// <summary>
/// Компонент логики
/// </summary>
public class GameLogicBL : MonoBehaviour
{
    /// <summary>
    /// Список параметров
    /// </summary>
    List<ParameterEntity> parameterList;

    /// <summary>
    /// Словарь локаций и переходов
    /// </summary>
    Dictionary<int, LocationEntity> locationDictionary;

    /// <summary>
    /// Словарь спрайтов
    /// </summary>
    Dictionary<SpritesKey, Sprite> spritesDictionary;

    /// <summary>
    /// Индекс текущей локации
    /// </summary>
    int m_indexCurentLocation = 0;

    /// <summary>
    /// Текущий список преходов на показе
    /// </summary>
    List<PassageEntity> passageViewList = new List<PassageEntity>();

    /// <summary>
    /// Текущий список параметров на показе
    /// </summary>
    List<string> parameterViewList = new List<string>();

    /// <summary>
    /// Компонент бинарной сериализации
    /// </summary>
    SerializatorBinaryDL serializatorBinaryDL;

    /// <summary>
    /// Событие установки спратов в TopMenuPanel
    /// </summary>
    public SetSpritesTopMenuPanelEvent setSpritesTopMenuPanelEvent = new SetSpritesTopMenuPanelEvent();

    /// <summary>
    /// Событие установки активности кнопки сохранения
    /// </summary>
    public SetActivitySaveGameButtonEvent setActivitySaveGameButtonEvent = new SetActivitySaveGameButtonEvent();

    /// <summary>
    /// Список пройденных локаций
    /// </summary>
    public List<int> traversedLocationTestList = new List<int>();

    // Use this for initialization
    void Start()
    {
        parameterList = new List<ParameterEntity>();
        locationDictionary = new Dictionary<int, LocationEntity>();
        spritesDictionary = new Dictionary<SpritesKey, Sprite>();

        serializatorBinaryDL = GetComponent<SerializatorBinaryDL>();

        GetComponent<LoadParameterDL>().LoadParameters(parameterList);
        GetComponent<LoadLocationPassageDL>().LoadLocationsPassages(locationDictionary);
        GetComponent<LoadSptitesDL>().LoadSptites(spritesDictionary);

        // Назначить первую локацию из locationDictionary
        foreach (KeyValuePair<int, LocationEntity> item in locationDictionary)
        {
            m_indexCurentLocation = item.Key;
            break;
        }

        if (GameObject.Find("LoadGame") != null)
        {
            LoadGame();
            Destroy(GameObject.Find("LoadGame"));
        }
        else
        {
            GeneratePassage();
            GenerateParameterTextList();
        }

        // Тест
        traversedLocationTestList.Add(m_indexCurentLocation);
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Дать текст текущей локации
    /// </summary>
    /// <returns></returns>
    public string GetLocationText()
    {
        if (locationDictionary == null)
        {
            print("GetLocationView (locationDictionary == null)");
            Start();
        }

        SetSpritesTopMenuPanel();
        SetMusicLocation();
        SetActivitySaveGameButton();
        PerformActionLocation();

        return locationDictionary[m_indexCurentLocation].Text;
    }

    /// <summary>
    /// Вызвать и предать в событие установки спрайтов на панель верхнего меню
    /// </summary>
    void SetSpritesTopMenuPanel()
    {
        try
        {
            setSpritesTopMenuPanelEvent.Invoke(
                spritesDictionary[locationDictionary[m_indexCurentLocation].BackgroundTopMenuPanel],
                spritesDictionary[locationDictionary[m_indexCurentLocation].PersonTopMenuPanel]);
        }
        catch
        {
            Debug.LogError("SetSpritesTopMenuPanel");
        }
    }

    /// <summary>
    /// Запустить музыку в локации
    /// </summary>
    void SetMusicLocation()
    {
        try
        {
            if (!locationDictionary[m_indexCurentLocation].MusicLocation.Equals(AudioKey.None))
            {
                AudioManagerBL.PlayMusic(locationDictionary[m_indexCurentLocation].MusicLocation);
            }
        }
        catch
        {
            Debug.LogError("SetMusicLocation");
        }
    }

    /// <summary>
    /// Выполнить действие локации
    /// </summary>
    void PerformActionLocation()
    {
        try
        {
            if (locationDictionary[m_indexCurentLocation].ActionLocation == ActionLocation.LoadGame)
            {
                LoadGame();
            }
            else if (locationDictionary[m_indexCurentLocation].ActionLocation == ActionLocation.NewGame)
            {
                GetComponent<SceneManagerBL>().LoadGameScene();
            }
            else if (locationDictionary[m_indexCurentLocation].ActionLocation == ActionLocation.MainMenu)
            {
                GetComponent<SceneManagerBL>().LoadMainMenuScene();
            }
        }
        catch
        {
            Debug.LogError("PerformActionLocation");
        }
    }

    /// <summary>
    /// Дать список текущих переходов
    /// </summary>
    /// <returns></returns>
    public List<PassageEntity> GetPassageViewList()
    {
        if (locationDictionary == null)
        {
            print("GetPassageViewList (locationDictionary == null)");
            Start();
        }

        return passageViewList;
    }

    /// <summary>
    /// Сгенерировать текущие преходы
    /// </summary>
    void GeneratePassage()
    {
        try
        {
            passageViewList.Clear();
            List<List<int>> passageIndexRemoveGroupList = new List<List<int>>();

            for (int i = 0; i < locationDictionary[m_indexCurentLocation].passageList.Count; i++)
            {
                // Если преход без параметров
                if (locationDictionary[m_indexCurentLocation].passageList[i].parameterEditList.Count.Equals(0))
                {
                    passageViewList.Add(locationDictionary[m_indexCurentLocation].passageList[i]);

                    // Если переход в группе
                    if (!locationDictionary[m_indexCurentLocation].passageList[i].Group.Equals(0))
                    {
                        try
                        {
                            passageIndexRemoveGroupList[locationDictionary[m_indexCurentLocation].passageList[i].Group - 1].Add(passageViewList.Count - 1);
                        }
                        catch
                        {
                            passageIndexRemoveGroupList.Add(new List<int>());
                            passageIndexRemoveGroupList[locationDictionary[m_indexCurentLocation].passageList[i].Group - 1].Add(passageViewList.Count - 1);
                        }
                    }
                }
                else
                {
                    bool flagAddPassage = true;

                    foreach (ParameterEditEntity itemParameterEditEntity in locationDictionary[m_indexCurentLocation].passageList[i].parameterEditList)
                    {
                        try
                        {
                            // Если параметр игрока не попадает в диапазон редактируемого параметра
                            if (!(itemParameterEditEntity.StartMustRangeValue <= parameterList[itemParameterEditEntity.IndexParameter].Value && itemParameterEditEntity.StopMustRangeValue >= parameterList[itemParameterEditEntity.IndexParameter].Value))
                            {
                                flagAddPassage = false;
                                break;
                            }
                        }
                        catch
                        {
                            print("Несоответствие параметров");
                        }
                    }

                    if (flagAddPassage)
                    {
                        passageViewList.Add(locationDictionary[m_indexCurentLocation].passageList[i]);

                        // Если переход в группе
                        if (!locationDictionary[m_indexCurentLocation].passageList[i].Group.Equals(0))
                        {
                            try
                            {
                                passageIndexRemoveGroupList[locationDictionary[m_indexCurentLocation].passageList[i].Group - 1].Add(passageViewList.Count - 1);
                            }
                            catch
                            {
                                passageIndexRemoveGroupList.Add(new List<int>());
                                passageIndexRemoveGroupList[locationDictionary[m_indexCurentLocation].passageList[i].Group - 1].Add(passageViewList.Count - 1);
                            }
                        }
                    }
                }
            }

            // Цикл из списка удаления индексов групповых преходов удаляет однин случайный индекс в каждой группе
            for (int i = passageIndexRemoveGroupList.Count - 1; i >= 0; i--)
            {
                passageIndexRemoveGroupList[i].RemoveAt(Random.Range(0, passageIndexRemoveGroupList[i].Count));
            }
            // Цикл из списка перходов на показ удаляет все групповые преходы кроме оставленых по одному преходу предыдущим циклом
            for (int i = passageIndexRemoveGroupList.Count - 1; i >= 0; i--)
            {
                for (int j = passageIndexRemoveGroupList[i].Count - 1; j >= 0; j--)
                {
                    passageViewList.RemoveAt(passageIndexRemoveGroupList[i][j]);
                }
            }
        }
        catch
        {
            Debug.LogError("GeneratePassage");
        }
    }

    /// <summary>
    /// Дать список текущих параметров
    /// </summary>
    /// <returns></returns>
    public List<string> GetParameterViewList()
    {
        if (parameterList == null)
        {
            print("GetParameterTextList");
            Start();
        }

        return parameterViewList;
    }

    /// <summary>
    /// Сгенерировать текущие параметры
    /// </summary>
    public void GenerateParameterTextList()
    {
        try
        {
            parameterViewList.Clear();

            foreach (ParameterEntity itemParameter in parameterList)
            {
                if (!OptionBL.TestJornalMode)
                {
                    if (itemParameter.Visible)
                    {
                        if (itemParameter.VisibleValueZero || !itemParameter.VisibleValueZero && !itemParameter.Value.Equals(0))
                        {
                            parameterViewList.Add(CreateParameterText(itemParameter));
                        }
                    }
                }
                else
                {
                    parameterViewList.Add(CreateParameterText(itemParameter) + (itemParameter.Visible == true ? " показ" : " закрыт"));
                }
            }
        }
        catch
        {
            Debug.LogError("GenerateParameterTextList");
        }
    }

    /// <summary>
    /// Создание текста параметра
    /// </summary>
    /// <param name="itemParameter">Параметр</param>
    /// <returns></returns>
    string CreateParameterText(ParameterEntity itemParameter)
    {
        try
        {
            string text = null;

            foreach (VisiblesRangeEntity itemVisiblesRange in itemParameter.visiblesRangeList)
            {
                if (itemVisiblesRange.StartRangeVisibleValue <= itemParameter.Value && itemVisiblesRange.StopRangeVisibleValue >= itemParameter.Value)
                {
                    text = itemVisiblesRange.Text;
                    break;
                }
            }

            string text2 = Regex.Replace(text, "<>", itemParameter.Value.ToString());

            string[] text3 = text2.Split('[', ']');
            for (int i = 0; i < text3.Length; i++)
            {
                if (text3[i].StartsWith("p") || text3[i].StartsWith("р")) // Англиская или русская буква
                {
                    //text3[i] = CreateParameterText(parameterList[System.Convert.ToInt32(text3[i].Substring(1))]); // Показать преобразованый параметр
                    text3[i] = parameterList[System.Convert.ToInt32(text3[i].Substring(1))].Value.ToString(); // Показать значение параметра
                }
            }
            string text4 = string.Join("", text3);

            return text4;
        }
        catch
        {
            Debug.LogError("CreateParameterText " + itemParameter.Name);
            return null;
        }
    }

    /// <summary>
    /// Установить текущую локацию
    /// </summary>
    /// <param name="indexCurentPassage">Индекс текущего перехода</param>
    public void SetCurentLocation(int indexCurentPassage)
    {
        m_indexCurentLocation = passageViewList[indexCurentPassage].NextIndexLocation;
        EditParameters(indexCurentPassage);

        GeneratePassage();
        GenerateParameterTextList();

        // Тест
        traversedLocationTestList.Add(m_indexCurentLocation);
    }

    /// <summary>
    /// Установить активность кнопки сохранения
    /// </summary>
    void SetActivitySaveGameButton()
    {
        try
        {
            if (m_indexCurentLocation >= 4700)
            {
                setActivitySaveGameButtonEvent.Invoke(false); // Если День 7
            }
            else
            {
                setActivitySaveGameButtonEvent.Invoke(true);
            }
        }
        catch
        {
            Debug.LogError("SetActivitySaveGameButton");
        }
    }

    /// <summary>
    /// Тест установить текущую локацию
    /// </summary>
    /// <param name="indexCurentPassage">Индекс текущего перехода</param>
    public void TestSetCurentLocation(int indexCurentLocation)
    {
        try
        {
            m_indexCurentLocation = indexCurentLocation;

            GeneratePassage();
            GenerateParameterTextList();

            // Тест
            traversedLocationTestList.Clear();
            traversedLocationTestList.Add(m_indexCurentLocation);
        }
        catch
        {
            Debug.LogError("TestSetCurentLocation");
        }
    }

    /// <summary>
    /// Изменить параметры
    /// </summary>
    /// <param name="indexCurentPassage">>Индекс текущего перехода</param>
    void EditParameters(int indexCurentPassage)
    {
        try
        {
            foreach (ParameterEditEntity item in passageViewList[indexCurentPassage].parameterEditList)
            {
                if (item.ValueEditAction == ValueEditAction.Equally)
                {
                    parameterList[item.IndexParameter].Value = item.ValueEdit;
                }
                else if (item.ValueEditAction == ValueEditAction.Plus)
                {
                    parameterList[item.IndexParameter].Value += item.ValueEdit;
                }
                else if (item.ValueEditAction == ValueEditAction.Minus)
                {
                    parameterList[item.IndexParameter].Value -= item.ValueEdit;
                }

                if (item.VisibleEdit == VisibleEdit.Show)
                {
                    parameterList[item.IndexParameter].Visible = true;
                }
                else if (item.VisibleEdit == VisibleEdit.Hide)
                {
                    parameterList[item.IndexParameter].Visible = false;
                }
            }
        }
        catch
        {
            Debug.LogError("EditParameters");
        }
    }

    /// <summary>
    /// Сохранение игры
    /// </summary>
    public void SaveGame()
    {
        try
        {
            serializatorBinaryDL.Serialization(new LoadSaveGameEntity { IndexCurentLocation = m_indexCurentLocation, parameterList = parameterList }, Application.persistentDataPath + "save.txt");
        }
        catch
        {
            Debug.LogError("SaveGame");
        }
    }

    /// <summary>
    /// Загрузка игры
    /// </summary>
    public void LoadGame()
    {
        try
        {
            LoadSaveGameEntity loadSaveEntity = serializatorBinaryDL.Deserialization<LoadSaveGameEntity>(Application.persistentDataPath + "save.txt");
            m_indexCurentLocation = loadSaveEntity.IndexCurentLocation;
            parameterList = loadSaveEntity.parameterList;

            GeneratePassage();
            GenerateParameterTextList();

            // Тест
            traversedLocationTestList.Clear();
            traversedLocationTestList.Add(m_indexCurentLocation);
        }
        catch
        {
            Debug.LogError("LoadGame");
        }
    }
}
