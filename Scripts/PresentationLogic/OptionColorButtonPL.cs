using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum StandardOption
{
    Standard1,
    Standard2,
    Standard3,
    Standard4
}

public class OptionColorButtonPL : MonoBehaviour
{
    public StandardOption standardOption;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// Обработчик события OnClick
    /// </summary>
    public void SetColorsInOption()
    {
        if (standardOption == StandardOption.Standard1)
        {
            //OptionBL.TextColor = new Color32(50, 50, 50, 255);
            //OptionBL.BackgroundColor = Color.white;
            //ColorBlock colorBlock = ColorBlock.defaultColorBlock;
            //OptionBL.ButtonColorBlock = colorBlock;
        }
        else if (standardOption == StandardOption.Standard2)
        {
            //OptionBL.TextColor = Color.white;
            //OptionBL.BackgroundColor = Color.black;
            //ColorBlock colorBlock = ColorBlock.defaultColorBlock;
            //colorBlock.normalColor = new Color32(255, 255, 255, 0);
            //OptionBL.ButtonColorBlock = colorBlock;
        }
        else if (standardOption == StandardOption.Standard3)
        {
        }
        else if (standardOption == StandardOption.Standard4)
        {
        }
    }
}
