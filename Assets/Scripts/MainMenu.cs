using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);   
    }
    public void ReturnToMainManu(){
        SceneManager.LoadScene(0);
    }
    public void Credits(){
        SceneManager.LoadScene(2);
    }
     public void RGame(){
        //Debug.Log(PlayerDeath.loadcount);
        //PlayerDeath.loadcount++;
        //Debug.Log("sayi arttı");
      SceneManager.LoadScene("SampleScene");
      Time.timeScale = 1f;
  } 
}
