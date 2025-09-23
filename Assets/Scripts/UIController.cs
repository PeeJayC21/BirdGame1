using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Slider musicSlider, SFXSlider;

    public void toggleMusic()
    {
        AudioManager.instance.toggleMusic();
    }

    public void toggleSFX()
    {
        AudioManager.instance.toggleSFX();
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
