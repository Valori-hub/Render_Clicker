using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    public AudioSource SFX;
    public AudioClip buttons;
    public AudioClip clicker;
    public AudioClip buy;


    public void Button()
    {
        SFX.clip = buttons;
        SFX.Play();
    }
    public void Buy()
    {
        SFX.clip = buy;
        SFX.Play();
    }

    public void Clicker()
    {
        if (ZmienneTag.isQuestTaken == 1)
        {
            SFX.clip = clicker;
            SFX.Play();
        }

    }
}
