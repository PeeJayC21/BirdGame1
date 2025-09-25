using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private bool isMusicMuted = false;
    private bool isSFXMuted = false;

    private float prevMusicVolume;
    private float prevSFXVolume;

    public bool getIsMusicMuted()
    {
        return isMusicMuted;
    }

    public bool getIsSFXMuted()
    {
        return isSFXMuted;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void playMusic(string name)
    {
        Sound sound = Array.Find(musicSounds, x => x.name == name);

        if (sound == null)
        {
            Debug.Log("Sound not found");
        }

        else
        {
            musicSource.clip = sound.clip;
            musicSource.Play();
        }
    }


    public void playSFX(string name)
    {
        Sound sfx = Array.Find(sfxSounds, x => x.name == name);

        if (sfx == null)
        {
            Debug.Log("sfx not found");
        }

        else
        {
            sfxSource.clip = sfx.clip;
            sfxSource.Play();
        }
    }

    public void toggleMusic()
    {
        if (isMusicMuted == false)
        {
            prevMusicVolume = musicSource.volume;
            musicSource.volume = 0.0f;
            isMusicMuted = true;
        }
        else
        {
            musicSource.volume = prevMusicVolume;
            isMusicMuted = false;
        }
       
    }
    public void toggleSFX()
    {
        if (isSFXMuted == false)
        {
            prevSFXVolume = sfxSource.volume;
            sfxSource.volume = 0.0f;
            isSFXMuted = true;
        }
        else
        {
            sfxSource.volume = prevSFXVolume;
            isSFXMuted = false;
        }
        
    }

    public float getMusicVolume()
    {
        return musicSource.volume;
    }

    public float getSFXVolume()
    {
        return sfxSource.volume;
    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }
    
}
