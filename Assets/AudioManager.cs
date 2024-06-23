using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource sfxAudioSource;

    public AudioClip nhacnen;
    public AudioClip dongxu;
    public AudioClip trumau;
    public AudioClip chienthang;
    public AudioClip thuacuoc;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = nhacnen;
        audioSource.Play();
    }

    public void Playsfx(AudioClip clip)
    {
        sfxAudioSource.clip = clip;
        sfxAudioSource.PlayOneShot(clip);
    }

    public void StopMusicBgr()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
