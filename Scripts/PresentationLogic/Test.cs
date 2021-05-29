using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void OnClick1()
    {
        OptionBL.Language = Language.Russian;
    }

    public void OnClick2()
    {
        OptionBL.Language = Language.English;
    }
}
