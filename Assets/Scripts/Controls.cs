using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    public float scroll;
    public float sensibility;
    public List<Image> Botones = new List<Image>();
    void Update()
    {
        Count();
        ImageChange();
    }

    void Count()
    {
        float y = Input.GetAxisRaw("Vertical");

        if (y > 0)
            scroll -= sensibility;

        if (y < 0)
            scroll += sensibility;

        if (scroll > 4)
        {
            scroll = 0;
        }
        else if (scroll < 0)
        {
            scroll = 4;
        }
    }

    void ImageChange()
    {
        if(scroll >= 0 && scroll < 1)
        {
            Botones[0].color = new Color(Botones[0].color.r, Botones[0].color.g, Botones[0].color.b, 0.5f);
            Botones[1].color = new Color(Botones[1].color.r, Botones[1].color.g, Botones[1].color.b, 0);
            Botones[2].color = new Color(Botones[2].color.r, Botones[2].color.g, Botones[2].color.b, 0);
            Botones[3].color = new Color(Botones[3].color.r, Botones[3].color.g, Botones[3].color.b, 0);
        }
        else if (scroll >= 1 && scroll < 2)
        {
            Botones[0].color = new Color(Botones[0].color.r, Botones[0].color.g, Botones[0].color.b, 0);
            Botones[1].color = new Color(Botones[1].color.r, Botones[1].color.g, Botones[1].color.b, 0.5f);
            Botones[2].color = new Color(Botones[2].color.r, Botones[2].color.g, Botones[2].color.b, 0);
            Botones[3].color = new Color(Botones[3].color.r, Botones[3].color.g, Botones[3].color.b, 0);
        }
        else if (scroll >= 2 && scroll < 3)
        {
            Botones[0].color = new Color(Botones[0].color.r, Botones[0].color.g, Botones[0].color.b, 0);
            Botones[1].color = new Color(Botones[1].color.r, Botones[1].color.g, Botones[1].color.b, 0);
            Botones[2].color = new Color(Botones[2].color.r, Botones[2].color.g, Botones[2].color.b, 0.5f);
            Botones[3].color = new Color(Botones[3].color.r, Botones[3].color.g, Botones[3].color.b, 0);
        }
        else if (scroll >= 3 && scroll < 4)
        {
            Botones[0].color = new Color(Botones[0].color.r, Botones[0].color.g, Botones[0].color.b, 0);
            Botones[1].color = new Color(Botones[1].color.r, Botones[1].color.g, Botones[1].color.b, 0);
            Botones[2].color = new Color(Botones[2].color.r, Botones[2].color.g, Botones[2].color.b, 0);
            Botones[3].color = new Color(Botones[3].color.r, Botones[3].color.g, Botones[3].color.b, 0.5f);
        }
    }
}
