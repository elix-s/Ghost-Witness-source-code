using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Компонент анимации открытия и закрытия панели
/// </summary>
public class OpenClosePanelAnimatorController : MonoBehaviour
{
    /// <summary>
    /// Компонент аниматор контролер
    /// </summary>
    Animator animator;

    /// <summary>
    /// Флаг состояния панели
    /// </summary>
    [HideInInspector]
    public bool openPanelFlag = false;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();


        // Редактирование анимации в сосответствии с текущим размером панели толко в UNITY_EDITOR
#if UNITY_EDITOR
        /// <summary>
        /// Компонент RectTransform
        /// </summary>
        RectTransform rectTransform;

        rectTransform = GetComponent<RectTransform>();

        // Подвинуть панель в сосответствии с текущим размером панели
        rectTransform.anchoredPosition = new Vector2(0, rectTransform.rect.height);

        animator.runtimeAnimatorController.animationClips[2].SetCurve("", typeof(RectTransform), "m_AnchoredPosition.y", new AnimationCurve(new Keyframe[] { new Keyframe(0.0f, rectTransform.rect.height), new Keyframe(0.25f, 0.0f) }));
        animator.runtimeAnimatorController.animationClips[3].SetCurve("", typeof(RectTransform), "m_AnchoredPosition.y", new AnimationCurve(new Keyframe[] { new Keyframe(0.0f, 0.0f), new Keyframe(0.25f, rectTransform.rect.height) }));
#endif
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Открытие или закрытие панели
    /// </summary>
    public void OpenClosePanel()
    {
        if (openPanelFlag)
        {
            animator.Play("OpenCloseAnimation");
            openPanelFlag = false;
        }
        else
        {
            animator.Play("CloseOpenAnimation");
            openPanelFlag = true;
        }
    }
}
