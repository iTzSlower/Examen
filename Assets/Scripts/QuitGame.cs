using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public bool Function;
    void Update()
    {
        if (Function)
            QuitG();
    }

    public void QuitG()
    {
        Application.Quit();
    }
}
