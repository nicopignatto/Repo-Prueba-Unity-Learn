using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    //esto supongo que ser�a un singleton.
    static public MainManager Instance;

    public Color colorDelEquipo;//esta variable hace referencia al color que va a tener el equipo(el montacargas)

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
