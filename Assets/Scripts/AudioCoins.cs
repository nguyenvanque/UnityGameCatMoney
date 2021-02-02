using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCoins : MonoBehaviour
{
    public static AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void playMusic()
    {
        audio.Play();
    }
}
