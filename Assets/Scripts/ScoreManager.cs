using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{ 
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public int score = 0;
    int highscore = 0;
    public static float scoreAmount;
    public float pointIncreasedPerSecond;
    void Start()
    {
             scoreAmount = 0f;
             pointIncreasedPerSecond = 1f;
    }
    void Update()
    {
    highscoreText.text = highscore.ToString();
        
          scoreText.text = "" + (int)Mathf.Round(scoreAmount);
          score = (int)Mathf.Round(scoreAmount);
          scoreAmount +=  pointIncreasedPerSecond * Time.deltaTime;
    if (score > PlayerPrefs.GetInt("highscore")){
         PlayerPrefs.SetInt("highscore", score);
        }
         highscoreText.text = PlayerPrefs.GetInt("highscore").ToString();
      PlayerPrefs.DeleteAll();
         
    }   
   
    
      
}
