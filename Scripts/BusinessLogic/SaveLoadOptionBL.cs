using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadOptionBL : MonoBehaviour
{
    /// <summary>
    /// Компонент бинарной сериализации
    /// </summary>
    SerializatorBinaryDL serializatorBinaryDL;

    // Use this for initialization
    void Start()
    {
        serializatorBinaryDL = GetComponent<SerializatorBinaryDL>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Сохранение игры
    /// </summary>
    public void SaveOption()
    {
        try
        {
            serializatorBinaryDL.Serialization(new LoadSaveOptionEntity { TextFontSize = OptionBL.LocationTextFontSize, MusicVolume = OptionBL.MusicVolume }, Application.persistentDataPath + "option.txt");
        }
        catch
        {
            Debug.LogError("SaveOption");
        }
    }

    /// <summary>
    /// Загрузка игры
    /// </summary>
    public void LoadOption()
    {
        try
        {
            LoadSaveOptionEntity loadSaveOptionEntity = serializatorBinaryDL.Deserialization<LoadSaveOptionEntity>(Application.persistentDataPath + "option.txt");
            OptionBL.LocationTextFontSize = loadSaveOptionEntity.TextFontSize;
            OptionBL.PassageTextFontSize = loadSaveOptionEntity.TextFontSize;
            OptionBL.ParameterTextFontSize = loadSaveOptionEntity.TextFontSize;
            OptionBL.MusicVolume = loadSaveOptionEntity.MusicVolume;
        }
        catch
        {
            Debug.LogError("LoadOption");
        }
    }
}
