using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nome : MonoBehaviour
{
    public string nameOfPlayer;
    public string saveName;
    public static string nomeScore;

    public Text inputText;
    
    void Start()
    {

    }

    void Update()
    {
        nameOfPlayer = PlayerPrefs.GetString("name", "nome");
        
        
    }
    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
        Nome.nomeScore = saveName;
    }
}

