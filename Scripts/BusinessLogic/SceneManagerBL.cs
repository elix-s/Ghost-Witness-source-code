using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagerBL : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
