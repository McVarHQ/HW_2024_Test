using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBgMusic : MonoBehaviour
{

    public AudioClip bgSound;
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = bgSound;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
