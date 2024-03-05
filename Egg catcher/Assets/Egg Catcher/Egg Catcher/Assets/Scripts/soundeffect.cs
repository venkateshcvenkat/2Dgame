using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeffect : MonoBehaviour
{
    public AudioSource sfx;
    public AudioClip clip1, clip2, clip3,clip4;
    public AudioSource Bgmusic;
    public static soundeffect instance;
    private void Awake()
    {
        instance = this;
    }


    public void click()
    {
        sfx.clip = clip1;
        sfx.Play();
    }

    public void stopmusic()
    {
        Bgmusic.GetComponent<AudioSource>().enabled = false;
    }
    public void over()
    {
        sfx.clip = clip2;
        sfx.Play();
    }
    public void eggcrack()
    {
        sfx.clip=clip3;
        sfx.Play();
    }
    public void eggcollect()
    {
        sfx.clip = clip4;
        sfx.Play();
    }
    
}
