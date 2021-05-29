using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.UI;
using System;

/// <summary>
/// Перечисление языков
/// </summary>
public enum Language
{
    Russian,
    English
}

/// <summary>
/// Схема события изменения языка
/// </summary>
public class SetLanguageEvent : UnityEvent<Language>
{
}

/// <summary>
/// Схема события изменения размера шрифта текста локаций
/// </summary>
public class SetLocationTextFontSizeEvent : UnityEvent<int>
{
}

/// <summary>
/// Схема события изменения размера шрифта текста переходов
/// </summary>
public class SetPassageTextFontSizeEvent : UnityEvent<int>
{
}

/// <summary>
/// Схема события изменения размера шрифта текста параметров
/// </summary>
public class SetParameterTextFontSizeEvent : UnityEvent<int>
{
}

///// <summary>
///// Схема события изменения цвета текста
///// </summary>
//public class SetTextColorEvent : UnityEvent<Color>
//{
//}

///// <summary>
///// Схема события изменения цвета фона
///// </summary>
//public class SetBackgroundColorEvent : UnityEvent<Color>
//{
//}

///// <summary>
///// Схема события изменения цвета кнопок
///// </summary>
//public class SetButtonColorBlockEvent : UnityEvent<ColorBlock>
//{
//}

/// <summary>
/// Схема события изменения громкости музыки
/// </summary>
public class SetMusicVolumeEvent : UnityEvent<float>
{
}

/// <summary>
/// Схема события изменения режима теста для журнала
/// </summary>
public class SetTestJornalModeEvent : UnityEvent<bool>
{
}

/// <summary>
/// Класс опций игры
/// </summary>
public static class OptionBL
{
    /// <summary>
    /// Текущий язык
    /// </summary>
    static Language language = Language.Russian;

    /// <summary>
    /// Текущий язык
    /// </summary>
    public static Language Language
    {
        get
        {
            return language;
        }

        set
        {
            if (!value.Equals(language))
            {
                language = value;
                setLanguageEvent.Invoke(language);
            }
        }
    }

    /// <summary>
    /// Размер шрифта текста локаций
    /// </summary>
    static int locationTextFontSize = 30;

    /// <summary>
    /// Размер шрифта текста локаций
    /// </summary>
    public static int LocationTextFontSize
    {
        get
        {
            return locationTextFontSize;
        }

        set
        {
            if (!value.Equals(locationTextFontSize))
            {
                locationTextFontSize = value;
                setLocationTextFontSizeEvent.Invoke(locationTextFontSize);
            }
        }
    }

    /// <summary>
    /// Размер шрифта текста переходов
    /// </summary>
    static int passageTextFontSize = 30;

    /// <summary>
    /// Размер шрифта текста переходов
    /// </summary>
    public static int PassageTextFontSize
    {
        get
        {
            return passageTextFontSize;
        }

        set
        {
            if (!value.Equals(passageTextFontSize))
            {
                passageTextFontSize = value;
                setPassageTextFontSizeEvent.Invoke(passageTextFontSize);
            }
        }
    }

    /// <summary>
    /// Размер шрифта текста параметров
    /// </summary>
    static int parameterTextFontSize = 30;

    /// <summary>
    /// Размер шрифта текста параметров
    /// </summary>
    public static int ParameterTextFontSize
    {
        get
        {
            return parameterTextFontSize;
        }

        set
        {
            if (!value.Equals(parameterTextFontSize))
            {
                parameterTextFontSize = value;
                setParameterTextFontSizeEvent.Invoke(parameterTextFontSize);
            }
        }
    }

    ///// <summary>
    ///// Цвет текста
    ///// </summary>
    //static Color textColor = new Color32(50, 50, 50, 255);

    ///// <summary>
    ///// Цвет текста
    ///// </summary>
    //public static Color TextColor
    //{
    //    get
    //    {
    //        return textColor;
    //    }

    //    set
    //    {
    //        if (!value.Equals(textColor))
    //        {
    //            textColor = value;
    //            setTextColorEvent.Invoke(textColor);
    //        }
    //    }
    //}

    ///// <summary>
    ///// Цвет фона
    ///// </summary>
    //static Color backgroundColor = Color.white;

    ///// <summary>
    ///// Цвет фона
    ///// </summary>
    //public static Color BackgroundColor
    //{
    //    get
    //    {
    //        return backgroundColor;
    //    }

    //    set
    //    {
    //        if (!value.Equals(backgroundColor))
    //        {
    //            backgroundColor = value;
    //            setBackgroundColorEvent.Invoke(backgroundColor);
    //        }
    //    }
    //}

    ///// <summary>
    ///// Цвет кнопок
    ///// </summary>
    //static ColorBlock buttonColorBlock = ColorBlock.defaultColorBlock;

    ///// <summary>
    ///// Цвет кнопок
    ///// </summary>
    //public static ColorBlock ButtonColorBlock
    //{
    //    get
    //    {
    //        return buttonColorBlock;
    //    }

    //    set
    //    {
    //        if (!value.Equals(buttonColorBlock))
    //        {
    //            buttonColorBlock = value;
    //            setButtonColorBlockEvent.Invoke(buttonColorBlock);
    //        }
    //    }
    //}

    /// <summary>
    /// Громкость музыки
    /// </summary>
    static float musicVolume = 1;

    /// <summary>
    /// Громкость музыки
    /// </summary>
    public static float MusicVolume
    {
        get
        {
            return musicVolume;
        }

        set
        {
            if (value < 0)
            {
                value = 0;
            }
            else if (value > 1)
            {
                value = 1;
            }
            if (!value.Equals(musicVolume))
            {
                musicVolume = value;
                setMusicVolumeEvent.Invoke(musicVolume);
            }
        }
    }

    /// <summary>
    /// Тестовый режим для журнала
    /// </summary>
    static bool testJornalMode = false;

    /// <summary>
    /// Тестовый режим для журнала
    /// </summary>
    public static bool TestJornalMode
    {
        get
        {
            return testJornalMode;
        }

        set
        {
            if (!value.Equals(testJornalMode))
            {
                testJornalMode = value;
                setTestJornalModeEvent.Invoke(testJornalMode);
            }
        }
    }

    /// <summary>
    /// Событие изменения языка
    /// </summary>
    public static SetLanguageEvent setLanguageEvent = new SetLanguageEvent();

    /// <summary>
    /// Событие изменения размера шрифта текста локаций
    /// </summary>
    public static SetLocationTextFontSizeEvent setLocationTextFontSizeEvent = new SetLocationTextFontSizeEvent();

    /// <summary>
    /// Событие изменения размера шрифта текста переходов
    /// </summary>
    public static SetPassageTextFontSizeEvent setPassageTextFontSizeEvent = new SetPassageTextFontSizeEvent();

    /// <summary>
    /// Событие изменения размера шрифта текста параметров
    /// </summary>
    public static SetParameterTextFontSizeEvent setParameterTextFontSizeEvent = new SetParameterTextFontSizeEvent();

    ///// <summary>
    ///// Событие изменения цвета текста
    ///// </summary>
    //public static SetTextColorEvent setTextColorEvent = new SetTextColorEvent();

    ///// <summary>
    ///// Событие изменения цвета фона
    ///// </summary>
    //public static SetBackgroundColorEvent setBackgroundColorEvent = new SetBackgroundColorEvent();

    ///// <summary>
    ///// Событие изменения цвета кнопок
    ///// </summary>
    //public static SetButtonColorBlockEvent setButtonColorBlockEvent = new SetButtonColorBlockEvent();

    /// <summary>
    /// Событие изменения громкости музыки
    /// </summary>
    public static SetMusicVolumeEvent setMusicVolumeEvent = new SetMusicVolumeEvent();

    /// <summary>
    /// Событие изменения тестового режима для журнала
    /// </summary>
    public static SetTestJornalModeEvent setTestJornalModeEvent = new SetTestJornalModeEvent();
}
