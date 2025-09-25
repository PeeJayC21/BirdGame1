using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Slider musicSlider, SFXSlider;
    public Button musicButton, sfxButton;

    public Sprite muteBtnSprite, unmuteBtnSprite;

    void Start()
    {
        musicSlider.value = AudioManager.instance.getMusicVolume();
        SFXSlider.value = AudioManager.instance.getSFXVolume();
    }

    void Update()
    {
        musicSlider.value = AudioManager.instance.getMusicVolume();
        SFXSlider.value = AudioManager.instance.getSFXVolume();
    }

    public void toggleMusic()
    {
        AudioManager.instance.toggleMusic();
        bool musicMuted = AudioManager.instance.getIsMusicMuted();

        musicButton.image.sprite = musicMuted ? muteBtnSprite : unmuteBtnSprite;

    }

    public void toggleSFX()
    {
        AudioManager.instance.toggleSFX();

        bool sfxMuted = AudioManager.instance.getIsSFXMuted();

        sfxButton.image.sprite = sfxMuted ? muteBtnSprite : unmuteBtnSprite;
    }

    public void musicVolume()
    {
        AudioManager.instance.MusicVolume(musicSlider.value);
    }


    public void sfxVolume()
    {
        AudioManager.instance.SFXVolume(SFXSlider.value);
    }
}
