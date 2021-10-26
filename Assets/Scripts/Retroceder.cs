using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retroceder : MonoBehaviour
{
    public string NameScene;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            LoadScene(NameScene);
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
        Debug.Log("VOLVER");
    }
}
