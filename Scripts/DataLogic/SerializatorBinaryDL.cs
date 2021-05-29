using UnityEngine;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/// <summary>
/// Компонент для сериализации объектов
/// </summary>
public class SerializatorBinaryDL : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Сериализует объект
    /// </summary>
    /// <param name="obj">Объект</param>
    /// <param name="filePath">Путь к файлу</param>
    public void Serialization(object obj, string filePath)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        MemoryStream memoryStream = new MemoryStream();
        binaryFormatter.Serialize(memoryStream, obj);

        try
        {
            File.WriteAllBytes(filePath, memoryStream.ToArray());
        }
        catch
        {
        }
    }

    /// <summary>
    /// Десериализует объект
    /// </summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    /// <param name="filePath">Путь к файлу</param>
    /// <returns></returns>
    public T Deserialization<T>(string filePath)
    {
        byte[] data = null;
        try
        {
            data = File.ReadAllBytes(filePath);
        }
        catch
        {
        }

        MemoryStream memoryStream = new MemoryStream();
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        memoryStream.Write(data, 0, data.Length);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return (T)binaryFormatter.Deserialize(memoryStream);
    }
}
