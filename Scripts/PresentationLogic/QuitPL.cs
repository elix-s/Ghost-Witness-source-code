using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// Компонент выхода из програмы
/// </summary>
public class QuitPL : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            GameObject.Find("MainScripts").GetComponent<SceneManagerBL>().LoadMainMenuScene();
        }
    }
}
