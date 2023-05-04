using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreCount : MonoBehaviour
{
    public static ScoreCount instance;
    public TextMeshProUGUI scoreText;
   
    int score=0;
   
    // Start is called before the first frame update
    void Start()
    {
       
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
      
        score += coinValue;
       
        scoreText.text="X"+score.ToString();
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();
    }
}
