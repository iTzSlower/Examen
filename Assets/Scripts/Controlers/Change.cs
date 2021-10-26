using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public bool Function;
    public Image Im;

    private void Start()
    {
        Im = GetComponent<Image>();
    }

    void Update()
    {
        if (Function)
            Cambio();

    }

    public void Cambio()
    {
        Im.color = new Color(Im.color.r, 1, Im.color.b, Im.color.a);
    }

}
