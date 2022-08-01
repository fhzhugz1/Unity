
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    

    
    public Text highScore;
    public Text nome;


    void Start()
    {
        
        highScore.text = timer.score;
        nome.text = Nome.nomeScore;

        
    }

   
}