using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

public class TestSaveLocationButtonPL : MonoBehaviour
{
    /// <summary>
    /// Компонент логики
    /// </summary>
    GameLogicBL logicBL;

    // Use this for initialization
    void Start()
    {
        logicBL = GameObject.Find("MainScripts").GetComponent<GameLogicBL>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SaveTraversedLocationTestList()
    {
        //Debug.LogError(Application.dataPath + "/Test.txt");
        StreamWriter fileOut = new StreamWriter(Application.dataPath + "/Test.txt", false);
        try
        {
            foreach (int item in logicBL.traversedLocationTestList)
            {
                fileOut.WriteLine(item);
            }
        }
        catch
        {
            print("error");
        }
        fileOut.Close();
    }
}
