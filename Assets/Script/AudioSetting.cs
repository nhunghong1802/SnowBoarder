using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSetting : MonoBehaviour
{
    [SerializeField] Slider sld;
    [SerializeField] Text vol;
    float num;

    // Start is called before the first frame update
    void Start()
    {
        //if(PlayerPrefs.HasKey("sldkey"))
        //{
        //    Load();
        //}
        //else
        {
            PlayerPrefs.SetFloat("sldkey", 0.2f);
            Load();
        }
    }

    public void Change()
    {
        AudioListener.volume= sld.value;
        num = sld.value * 100;
        vol.text = num.ToString("0") + "%";
        Save();
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("sldkey", sld.value);
        Load();
    }
    public void Load()
    {
        sld.value = PlayerPrefs.GetFloat("sldkey");
    }
}
