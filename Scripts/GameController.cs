using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    
     public int totalScore;
     public Text scoreText;
     public Text scoreGameOver;
     public static GameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
        {
           scoreText.text = totalScore.ToString();
           scoreGameOver.text = totalScore.ToString();
        }
    
}
