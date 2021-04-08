using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
  public Text pointsText;
  public GameObject pointScore;

  public void Setup (int score){
      gameObject.SetActive(true);
      pointsText.text = score.ToString() + " POINTS";
  } 
  public void restartButton(){
      SceneManager.LoadScene("lvl_2");
  }
  public void ExitButton(){
      SceneManager.LoadScene("lvl_2");

  }

}