using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VistaMenu : MonoBehaviour
{
    public ModelMenu Model;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ImageChange()
    {
        if (Model.scroll >= 0 && Model.scroll < 1)
        {
            Model.Botones[0].color = new Color(Model.Botones[0].color.r, Model.Botones[0].color.g, Model.Botones[0].color.b, 0.5f);
            Model.Botones[1].color = new Color(Model.Botones[1].color.r, Model.Botones[1].color.g, Model.Botones[1].color.b, 0);
            Model.Botones[2].color = new Color(Model.Botones[2].color.r, Model.Botones[2].color.g, Model.Botones[2].color.b, 0);
            Model.Botones[3].color = new Color(Model.Botones[3].color.r, Model.Botones[3].color.g, Model.Botones[3].color.b, 0);
        }
        else if (Model.scroll >= 1 && Model.scroll < 2)
        {
            Model.Botones[0].color = new Color(Model.Botones[0].color.r, Model.Botones[0].color.g, Model.Botones[0].color.b, 0);
            Model.Botones[1].color = new Color(Model.Botones[1].color.r, Model.Botones[1].color.g, Model.Botones[1].color.b, 0.5f);
            Model.Botones[2].color = new Color(Model.Botones[2].color.r, Model.Botones[2].color.g, Model.Botones[2].color.b, 0);
            Model.Botones[3].color = new Color(Model.Botones[3].color.r, Model.Botones[3].color.g, Model.Botones[3].color.b, 0);
        }
        else if (Model.scroll >= 2 && Model.scroll < 3)
        {
            Model.Botones[0].color = new Color(Model.Botones[0].color.r, Model.Botones[0].color.g, Model.Botones[0].color.b, 0);
            Model.Botones[1].color = new Color(Model.Botones[1].color.r, Model.Botones[1].color.g, Model.Botones[1].color.b, 0);
            Model.Botones[2].color = new Color(Model.Botones[2].color.r, Model.Botones[2].color.g, Model.Botones[2].color.b, 0.5f);
            Model.Botones[3].color = new Color(Model.Botones[3].color.r, Model.Botones[3].color.g, Model.Botones[3].color.b, 0);
        }
        else if (Model.scroll >= 3 && Model.scroll < 4)
        {
            Model.Botones[0].color = new Color(Model.Botones[0].color.r, Model.Botones[0].color.g, Model.Botones[0].color.b, 0);
            Model.Botones[1].color = new Color(Model.Botones[1].color.r, Model.Botones[1].color.g, Model.Botones[1].color.b, 0);
            Model.Botones[2].color = new Color(Model.Botones[2].color.r, Model.Botones[2].color.g, Model.Botones[2].color.b, 0);
            Model.Botones[3].color = new Color(Model.Botones[3].color.r, Model.Botones[3].color.g, Model.Botones[3].color.b, 0.5f);
        }
    }
}
