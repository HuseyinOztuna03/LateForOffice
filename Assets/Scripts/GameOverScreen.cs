using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    
  
  public TextMeshProUGUI Score, HighScore, GOScore, GOHighScore;
  public void Setup(){
   GOScore.text = Score.text;
   GOHighScore.text =  HighScore.text;
    
    gameObject.SetActive(true);
  }
}