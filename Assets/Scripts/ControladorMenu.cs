using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    public ModelMenu model;
    public VistaMenu Vista;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count();
        //Cambio();
    }
     public void count()
    {
        
        
            float y = Input.GetAxisRaw("Vertical");

            if (y > 0)
                model.scroll += model.sensibility;

            if (y < 0)
               model.scroll += model.sensibility;

            if (model.scroll > 4)
            {
                model.scroll = 0;
            }
            else if (model.scroll < 0)
            {
                model.scroll = 4;
            }
        
    }
    /*public void Cambio()
    {
        if (model.scroll >= 0 && model.scroll < 1)
        {
            if (Input.GetKeyDown("Enter"))
            {
                changescene("PERSONAJE");
            }
        }
        if (model.scroll >= 1 && model.scroll < 2)
        {
            if (Input.GetKeyDown("Enter"))
            {
                Debug.Log("ESTAS EN OPCIONES");
            }
        }
        if (model.scroll >= 2 && model.scroll < 3)
        {
            if (Input.GetKeyDown("Enter"))
            {
                Debug.Log("Estas en Creditos");
            }
        }
        if (model.scroll >= 3 && model.scroll < 4)
        {
            if (Input.GetKeyDown("Enter"))
            {
                Debug.Log("Estas en salir");
            }
        }
    }
  
    
        public void changescene(string scenename)
        {
            SceneManager.LoadScene(scenename);
        }*/
    
}
