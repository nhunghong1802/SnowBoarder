using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    AudioSource audio;
    int MusicBackground;
    public Toggle MusicBackgroundCheck;
    // Start is called before the first frame update
    void Start()
    {
        MusicBackground = PlayerPrefs.GetInt("MusicBackground");
        
        audio = GetComponent<AudioSource>();
        
        if(MusicBackground == 1)
        {
            MusicBackgroundCheck.isOn = true;
            //audio.Play();
        }
        else
            MusicBackgroundCheck.isOn = false;
        //audio.Stop();
    }

    public void OnOffMusicBackground()
    {
        if (MusicBackgroundCheck.isOn)
        {
            audio.Play();
            PlayerPrefs.SetInt("MusicBackground", 1);
        }
        else
        {
            ; audio.Pause();
            PlayerPrefs.SetInt("MusicBackground", 0);
        }
    }
}
