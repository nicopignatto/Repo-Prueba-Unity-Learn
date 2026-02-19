
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
        LoadColor();
    }

    [Serializable]
    public class SaveData
    {
        public Color teamColor;
    }

    public void SaveColor()
    {
        SaveData data = new SaveData();
        data.teamColor = teamColor;

        string json=JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/SavePlayerFile.json", json);

    }

    public void LoadColor()
    {
        string path = Application.persistentDataPath + "/SavePlayerFile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            teamColor = data.teamColor;
        }
    }

}