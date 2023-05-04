using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Debug.Log("You earn a coin");
            soundManagement.instance.coinSource.PlayOneShot(soundManagement.instance.coinClip);
            Destroy(collision.gameObject);
        }
    }
}
