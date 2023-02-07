using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource[] audioSources;
    public float TimeStart = 0.0f;
    public float TimeStop = 1f;
    public RootBehavior rootBehavior;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        audioSource.time = TimeStart;
    }

    // Update is called once per frame
    void Update()
    {
        if (rootBehavior.isDone && !audioSource.isPlaying && audioSource.mute == false)
        {
            StopAllAudio();
            audioSource.Play();
        }
        if (audioSource.time >= TimeStop)
        {
            audioSource.Stop();
            audioSource.mute = true;
        }
    }

    public void StopAllAudio()
    {
        foreach (AudioSource audioS in audioSources)
        {
            audioS.Stop();
        }
    }
}
