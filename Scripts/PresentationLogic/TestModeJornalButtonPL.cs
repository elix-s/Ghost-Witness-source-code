using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestModeJornalButtonPL : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClick()
    {
        OptionBL.TestJornalMode = !OptionBL.TestJornalMode;
    }
}
