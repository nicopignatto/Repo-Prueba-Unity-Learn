using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    //esto supongo que sería un singleton.
    public static MainManager Instance;

    public Color teamColor;//esta variable hace referencia al color que va a tener el equipo(el montacargas)

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
