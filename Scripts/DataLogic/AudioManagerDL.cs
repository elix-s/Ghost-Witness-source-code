using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Перечисление аудио ключей
/// </summary>
public enum AudioKey
{
    None,
    Clouds,
    Crypto,
    DarkWalk,
    Decisions,
    FatCaps,
    Front,
    HotelMusic,
    Lost,
    Namaste,
    PoliceMusic,
    Rising,
    RiverMeditation
}

/// <summary>
/// Компонент загрузки аудио
/// </summary>
public class AudioManagerDL : MonoBehaviour
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
    /// Загрузка аудио
    /// </summary>
    /// <param name="audioDictionary">Словарь аудио</param>
    public void LoadAudio(Dictionary<AudioKey, AudioClip> audioDictionary)
    {
        audioDictionary.Clear();

        audioDictionary.Add(AudioKey.None, null);
        audioDictionary.Add(AudioKey.Clouds, Resources.Load<AudioClip>("Audio\\Music\\Clouds"));
        audioDictionary.Add(AudioKey.Crypto, Resources.Load<AudioClip>("Audio\\Music\\Crypto"));
        audioDictionary.Add(AudioKey.DarkWalk, Resources.Load<AudioClip>("Audio\\Music\\DarkWalk"));
        audioDictionary.Add(AudioKey.Decisions, Resources.Load<AudioClip>("Audio\\Music\\Decisions"));
        audioDictionary.Add(AudioKey.FatCaps, Resources.Load<AudioClip>("Audio\\Music\\FatCaps"));
        audioDictionary.Add(AudioKey.Front, Resources.Load<AudioClip>("Audio\\Music\\Front"));
        audioDictionary.Add(AudioKey.HotelMusic, Resources.Load<AudioClip>("Audio\\Music\\HotelMusic"));
        audioDictionary.Add(AudioKey.Lost, Resources.Load<AudioClip>("Audio\\Music\\Lost"));
        audioDictionary.Add(AudioKey.Namaste, Resources.Load<AudioClip>("Audio\\Music\\Namaste"));
        audioDictionary.Add(AudioKey.PoliceMusic, Resources.Load<AudioClip>("Audio\\Music\\PoliceMusic"));
        audioDictionary.Add(AudioKey.Rising, Resources.Load<AudioClip>("Audio\\Music\\Rising"));
        audioDictionary.Add(AudioKey.RiverMeditation, Resources.Load<AudioClip>("Audio\\Music\\RiverMeditation"));
    }
}
