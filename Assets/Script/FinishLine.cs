using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class FinishLine : MonoBehaviour
{
    int i = 0;
    [SerializeField] float timeDelay=1f;
   
    public int  value=0;
    [SerializeField] ParticleSystem finishEffect;
    public int totalPoint;
     void OnTriggerEnter2D(Collider2D other)
    { i++;
        if (other.tag == "Player")
        {
           
          
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", timeDelay);
         
          
        }
       
    }
    void ReloadScene()
    {
       
        Debug.Log("This is scene " + i);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);//ham nay de load scene lan luot
         value += PlayerPrefs.GetInt("score");
        Debug.Log(value);
    }
}
