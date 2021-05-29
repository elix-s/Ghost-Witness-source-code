using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Компонент вывода звука
/// </summary>
public class SoundAudioManagerPL : MonoBehaviour
{
    /// <summary>
    /// Компонент работы со звуковым источником
    /// </summary>
    AudioSource soundAudioSource;

    /// <summary>
    /// Максимальная громкость
    /// </summary>
    float m_VolumeMax = 1;

    void Awake()
    {
        soundAudioSource = GetComponent<AudioSource>();
        GameObject.Find("AudioManager").GetComponent<AudioManagerBL>().startAudioEvent.AddListener(StartSound);
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(!soundAudioSource.isPlaying)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Старт воспроизведения звука
    /// </summary>
    /// <param name="audioClip">Аудио клип</param>
    void StartSound(AudioClip audioClip)
    {
        soundAudioSource.clip = audioClip;
        soundAudioSource.volume = m_VolumeMax;
        soundAudioSource.Play();
        GameObject.Find("AudioManager").GetComponent<AudioManagerBL>().startAudioEvent.RemoveListener(StartSound);
    }

    /// <summary>
    /// Изменение громкости звука
    /// </summary>
    /// <param name="soundVolume">Громкость звука</param>
    void SetSoundVolume(float soundVolume)
    {
        m_VolumeMax = soundVolume;
        soundAudioSource.volume = soundVolume;
    }
}
