using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public ColorPicker ColorPicker;

    public void NewColorSelected(Color color)
    {
        // add code here to handle when a color is selected
        MainManager.Instance.colorDelEquipo = color;
    }
    
    private void Start()
    {
        ColorPicker.Init();
        //this will call the NewColorSelected function when the color picker have a color button clicked.
        ColorPicker.onColorChanged += NewColorSelected;
    }

    public void CargarEscenaNueva()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SalirDeLaApp()
    {
        Application.Quit();//esta linea solo se ejecuta cuando se tiene una build del juego.
        print("Salgo del juego");
    }
}
