using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicVolumeSliderOptionPL : MonoBehaviour
{
    /// <summary>
    /// Компонент слайдер громкости музыки
    /// </summary>
    Slider musicVolumeSlider;

    // Use this for initialization
    void Start ()
    {
        musicVolumeSlider = GetComponent<Slider>();

        musicVolumeSlider.value = OptionBL.MusicVolume;
    }
	
	// Update is called once per frame
	void Update ()
    {
	}

    /// <summary>
    /// Установить в опциях громкость музыки
    /// </summary>
    public void SetMusicVolumeOption()
    {
        OptionBL.MusicVolume = musicVolumeSlider.value;
    }
}
