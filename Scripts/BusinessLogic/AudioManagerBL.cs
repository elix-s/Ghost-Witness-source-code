using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;

/// <summary>
/// Схема события старта аудио 
/// </summary>
public class StartAudioEvent : UnityEvent<AudioClip>
{
}

/// <summary>
/// Компонент логики аудио
/// </summary>
public class AudioManagerBL : MonoBehaviour
{
    /// <summary>
    /// Словарь аудио
    /// </summary>
    Dictionary<AudioKey, AudioClip> audioDictionary;

    /// <summary>
    /// Экземпляр AudioManagerBL
    /// </summary>
    static AudioManagerBL instance;

    /// <summary>
    /// Экземпляр AudioManagerBL
    /// </summary>
    static AudioManagerBL Instance
    {
        get
        {
            if (instance != null)
            {
                return instance;
            }

            return new GameObject("AudioManager").AddComponent<AudioManagerBL>();
        }
    }

    /// <summary>
    /// Событие старта воспроизведения аудио
    /// </summary>
    public StartAudioEvent startAudioEvent = new StartAudioEvent();

    /// <summary>
    /// Событие остановки воспроизведения аудио
    /// </summary>
    public UnityEvent stopAudioEvent = new UnityEvent();

    /// <summary>
    /// Старт воспроизведения аудио как музыки
    /// </summary>
    /// <param name="audioKey">Аудио ключ</param>
    public static void PlayMusic(AudioKey audioKey)
    {
        Instance.PlayMusicInternal(audioKey);
    }

    /// <summary>
    /// Остановка воспроизведения музыки
    /// </summary>
    public static void StopMusic()
    {
        Instance.StopMusicInternal();
    }

    /// <summary>
    /// Старт воспроизведения аудио как звука
    /// </summary>
    /// <param name="audioKey">Аудио ключ</param>
    public static void PlaySound(AudioKey audioKey)
    {
        Instance.PlaySoundInternal(audioKey);
    }

    void Awake()
    {
        instance = this;
        audioDictionary = new Dictionary<AudioKey, AudioClip>();
        gameObject.AddComponent<AudioManagerDL>().LoadAudio(audioDictionary);
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Внутрений старт воспроизведения аудио как музыки
    /// </summary>
    /// <param name="audioKey">Аудио ключ</param>
    void PlayMusicInternal(AudioKey audioKey)
    {
        if (GameObject.Find("Music: " + audioKey) == null)
        {
            stopAudioEvent.Invoke();

            GameObject music = new GameObject("Music: " + audioKey);
            music.AddComponent<AudioSource>();
            music.AddComponent<MusicAudioManagerPL>();
            music.transform.SetParent(transform);

            startAudioEvent.Invoke(audioDictionary[audioKey]);
        }
    }

    /// <summary>
    /// Внутреняя остановка воспроизведения музыки
    /// </summary>
    void StopMusicInternal()
    {
        stopAudioEvent.Invoke();
    }

    /// <summary>
    /// Внутрений старт воспроизведения аудио как звука
    /// </summary>
    /// <param name="audioKey">Аудио ключ</param>
    void PlaySoundInternal(AudioKey audioKey)
    {
        GameObject music = new GameObject("Sound: " + audioKey);
        music.AddComponent<AudioSource>();
        music.AddComponent<SoundAudioManagerPL>();
        music.transform.SetParent(transform);

        startAudioEvent.Invoke(audioDictionary[audioKey]);
    }
}
