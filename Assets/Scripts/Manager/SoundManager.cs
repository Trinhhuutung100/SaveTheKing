using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public enum SoundType {
    BGM,
    Commit,
    SpawnBox,
    Congrats,
    Click,
    Lose,
};

public class SoundManager : Ply_Singleton<SoundManager>
{
    public override void Awake()
    {
        base.Awake();
    }

    public AudioSource[] audios;

    public void playSound(SoundType soundType, bool loop = false)
    {
        if((int)soundType < audios.Length)
        {
            audios[(int)soundType].loop = loop;
            audios[(int)soundType].Play();
        }
    }
    public void stopSound(SoundType soundType)
    {
        audios[(int)soundType].Stop();
    }
    public void muteSound(SoundType soundType)
    {
        audios[(int)soundType].mute = true;
    }
    public void unmuteSound(SoundType soundType)
    {
        audios[(int)soundType].mute = false;
    }



    public void muteAllSounds()
    {
        foreach (var sound in audios) { 
            sound.mute = true;
        }
    }
    public void unmuteAllSounds()
    {
        foreach (var sound in audios)
        {
            sound.mute = false;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        playSound(SoundType.BGM, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
