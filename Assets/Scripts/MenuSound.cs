using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSound : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip soundmenu;

    public void SoundButton()
    {
        sound.clip = soundmenu;
        sound.enabled = false;
        sound.enabled = true;
    }
}
