using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Компонент отображения панели верхнего меню
/// </summary>
public class TopMenuPanelPL : MonoBehaviour
{
    /// <summary>
    /// Компонент рисунок
    /// </summary>
    Image backgroundImage;

    /// <summary>
    /// Компонент рисунок у PersonImage
    /// </summary>
    Image personImage;

    /// <summary>
    /// Компонент CanvasGroup у PersonImage
    /// </summary>
    CanvasGroup personCanvasGroup;

    /// <summary>
    /// Компонент OpenClosePanelAnimatorController у JournalScrollView
    /// </summary>
    OpenClosePanelAnimatorController openClosePanelAnimatorControllerParameter;

    /// <summary>
    /// Компонент OpenClosePanelAnimatorController у OptionPanel
    /// </summary>
    OpenClosePanelAnimatorController openClosePanelAnimatorControllerOption;

    // Use this for initialization
    void Start()
    {
        backgroundImage = GetComponent<Image>();
        personImage = GameObject.Find("PersonImage").GetComponent<Image>();
        personCanvasGroup = GameObject.Find("PersonImage").GetComponent<CanvasGroup>();
        openClosePanelAnimatorControllerParameter = GameObject.Find("JournalScrollView").GetComponent<OpenClosePanelAnimatorController>();
        openClosePanelAnimatorControllerOption = GameObject.Find("OptionPanel").GetComponent<OpenClosePanelAnimatorController>();

        GameObject.Find("MainScripts").GetComponent<GameLogicBL>().setSpritesTopMenuPanelEvent.AddListener(SetImages);
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Установить картинки в панель верхнего меню
    /// </summary>
    /// <param name="backgroundSprite">Фоновая картинка</param>
    /// <param name="personSprite">Картинка персонажа</param>
    void SetImages(Sprite backgroundSprite, Sprite personSprite)
    {
        if (backgroundSprite != null)
        {
            backgroundImage.overrideSprite = backgroundSprite;
        }
        if (personSprite == null)
        {
            personCanvasGroup.alpha = 0;
        }
        else
        {
            personImage.overrideSprite = personSprite;
            personCanvasGroup.alpha = 1;
        }
    }

    /// <summary>
    /// Изменить состояние JournalScrollView
    /// </summary>
    public void SetOpenCloseParameterScrollView()
    {
        if (openClosePanelAnimatorControllerOption.openPanelFlag)
        {
            openClosePanelAnimatorControllerOption.OpenClosePanel();
            openClosePanelAnimatorControllerParameter.OpenClosePanel();
        }
        else
        {
            openClosePanelAnimatorControllerParameter.OpenClosePanel();
        }
    }

    /// <summary>
    /// Изменить состояние OptionPanel
    /// </summary>
    public void SetOpenCloseOptionPanel()
    {
        if (openClosePanelAnimatorControllerParameter.openPanelFlag)
        {
            openClosePanelAnimatorControllerParameter.OpenClosePanel();
            openClosePanelAnimatorControllerOption.OpenClosePanel();
        }
        else
        {
            openClosePanelAnimatorControllerOption.OpenClosePanel();
        }
    }
}
