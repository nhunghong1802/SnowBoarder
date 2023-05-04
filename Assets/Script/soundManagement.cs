using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagement : MonoBehaviour
{
    public static soundManagement instance;
    public AudioSource coinSource;
    public AudioClip coinClip;

   
    private void Awake()
    {
       instance= this;
    }
    // Start is called before the first frame update
    void Start()
    {
        coinSource= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    
}
