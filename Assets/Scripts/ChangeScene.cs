using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string NameScene;
    public bool Function;
    public bool Exit_or_Change;

    void Update()
    {
        if(Function && !Exit_or_Change)
            LoadScene(NameScene);

        if (Function && Exit_or_Change)
            QuitGame();
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("SALIR");
    }
}
