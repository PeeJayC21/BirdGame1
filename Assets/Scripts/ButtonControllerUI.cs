using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControllerUI : MonoBehaviour
{
    public Button musicBtn;
    public Button sfxButton;

    public Sprite unmutedBtnSprite;
    public Sprite muteBtnSprite;


    public void checkMusicBtnState()
    {
        bool musicMuted = AudioManager.instance.getIsMusicMuted();


        musicBtn.image.sprite = musicMuted ? muteBtnSprite : unmutedBtnSprite;
    }

    public void checkSFXBtnState()
    {
        bool SFXMuted = AudioManager.instance.getIsSFXMuted();

        sfxButton.image.sprite = SFXMuted ? muteBtnSprite : unmutedBtnSprite;
    }
}
