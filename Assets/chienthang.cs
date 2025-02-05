using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chienthang : MonoBehaviour
{
    private AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioManager.Playsfx(audioManager.chienthang);
            Destroy(gameObject);
        }
    }
}
