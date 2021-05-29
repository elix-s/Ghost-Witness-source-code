using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Компонент вывода музыки
/// </summary>
public class MusicAudioManagerPL : MonoBehaviour
{
    /// <summary>
    /// Компонент работы со звуковым источником
    /// </summary>
    AudioSource musicAudioSource;

    /// <summary>
    /// Максимальная громкость
    /// </summary>
    float m_VolumeMax = 1;

    /// <summary>
    /// Интервал изменения звука при старте или остановки музыки
    /// </summary>
    float m_VolumeInterval = 0.02f;

    void Awake()
    {
        musicAudioSource = GetComponent<AudioSource>();
        GameObject.Find("AudioManager").GetComponent<AudioManagerBL>().startAudioEvent.AddListener(StartMusic);
        GameObject.Find("AudioManager").GetComponent<AudioManagerBL>().stopAudioEvent.AddListener(StopMusic);
        OptionBL.setMusicVolumeEvent.AddListener(SetMusicVolume);

        SetMusicVolume(OptionBL.MusicVolume);
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
    /// Старт воспроизведения музыки
    /// </summary>
    /// <param name="audioClip">Аудио клип</param>
    void StartMusic(AudioClip audioClip)
    {
        musicAudioSource.clip = audioClip;
        musicAudioSource.volume = 0;
        musicAudioSource.loop = true;
        musicAudioSource.Play();
        StartCoroutine(UprisingMusicCoroutine());
        GameObject.Find("AudioManager").GetComponent<AudioManagerBL>().startAudioEvent.RemoveListener(StartMusic);
    }

    /// <summary>
    /// Старт возникновения громкости музыки
    /// </summary>
    /// <returns></returns>
    IEnumerator UprisingMusicCoroutine()
    {
        for (float i = 0; i < m_VolumeMax; i += m_VolumeInterval)
        {
            musicAudioSource.volume = i;
            yield return new WaitForSeconds(0.01f);
        }
        musicAudioSource.volume = m_VolumeMax;
    }

    /// <summary>
    /// Остановка воспроизведения музыки
    /// </summary>
    void StopMusic()
    {
        StartCoroutine(FadingMusicCoroutine());
    }

    /// <summary>
    /// Старт затухания громкости музыки
    /// </summary>
    /// <returns></returns>
    IEnumerator FadingMusicCoroutine()
    {
        for (float i = m_VolumeMax; i >= 0; i -= m_VolumeInterval)
        {
            musicAudioSource.volume = i;
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(gameObject);
    }

    /// <summary>
    /// Изменение громкости музыки
    /// </summary>
    /// <param name="musicVolume">Громкость музыки</param>
    void SetMusicVolume(float musicVolume)
    {
        m_VolumeMax = musicVolume;
        musicAudioSource.volume = musicVolume;
    }
}
