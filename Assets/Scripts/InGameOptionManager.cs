using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class InGameOptionManager : MonoBehaviour
{
    public GameObject OptionPanel;
    private LogicSCript logicSCript;

    public Slider musicSlider;

    public Slider sfxSlider;

    public ButtonControllerUI musicButtonController;
    public ButtonControllerUI sfxButtonController;

    void Start()
    {
        logicSCript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicSCript>();
        musicSlider.value = AudioManager.instance.getMusicVolume();
        sfxSlider.value = AudioManager.instance.getSFXVolume();
    }


    void Update()
    {
        musicSlider.value = AudioManager.instance.getMusicVolume();
        sfxSlider.value = AudioManager.instance.getSFXVolume();
    }

    public void TogglePause()
    {

        OptionPanel.SetActive(true);
        logicSCript.TogglePause();
    }

    public void ToggleResume()
    {

        OptionPanel.SetActive(false);
        logicSCript.ToggleResume();
    }

    public void ToggleMainMenu()
    {
        logicSCript.ToggleMainMenu();
    }

    public void muteMusic()
    {
        AudioManager.instance.toggleMusic();
        musicButtonController.checkMusicBtnState();

        musicSlider.value = AudioManager.instance.getIsMusicMuted() ? 0f : AudioManager.instance.getMusicVolume();
        
    }

    public void muteSFX()
    {
        AudioManager.instance.toggleSFX();
        sfxButtonController.checkSFXBtnState();

        sfxSlider.value = AudioManager.instance.getIsSFXMuted() ? 0f : AudioManager.instance.getSFXVolume();
    }

    public void musicVolume()
    {
        AudioManager.instance.MusicVolume(musicSlider.value);
        
    }

    public void sfxVolume()
    {
        AudioManager.instance.SFXVolume(sfxSlider.value);
        
    }



}
