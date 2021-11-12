using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int countDownStartValue = 4;

    public Text timerText;
    bool FirstTimer;
    bool SecondTimer;
    bool ThirdTimer;
    bool FourthTimer;

    public Button buttonTimer;
    public Button buttonNext;
    public Button PlayerOneButton;
    public Button PlayerTwoButton;

    public static bool ChangeVolume = false;

    // Start is called before the first frame update
    void Start()
    {
        FirstTimer = true;
        SecondTimer = false;
        ThirdTimer = false;
        FourthTimer = false;
        buttonNext.interactable = false;
        PlayerOneButton.interactable = false;
        PlayerTwoButton.interactable = false;
    }

    public void countDownTimer()
    {
        if(countDownStartValue > 0)
        {
            AudioManager.instance.Play("Clock");
            AudioManager.instance.SetVolume("Theme");
            ChangeVolume = true;
            buttonTimer.interactable = false;
            timerText.text = "" + countDownStartValue;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            AudioManager.instance.Stop("Clock");
            AudioManager.instance.Play("Bell");
            buttonTimer.interactable = true;
            timerText.text = "";
            if(FirstTimer && !SecondTimer && !ThirdTimer && !FourthTimer)
            {
                countDownStartValue = 45;
                FirstTimer = false;
                SecondTimer = true;
                ThirdTimer = false;
                FourthTimer = false;
            }
            else if(!FirstTimer && SecondTimer && !ThirdTimer && !FourthTimer)
            {
                countDownStartValue = 30;
                FirstTimer = false;
                SecondTimer = false;
                ThirdTimer = true;
                FourthTimer = false;
            }
            else if(!FirstTimer && !SecondTimer && ThirdTimer && !FourthTimer)
            {
                countDownStartValue = 30;
                FirstTimer = false;
                SecondTimer = false;
                ThirdTimer = false;
                FourthTimer = true;
            }
            else if(!FirstTimer && !SecondTimer && !ThirdTimer && FourthTimer)
            {
                countDownStartValue = 45;
                FirstTimer = true;
                SecondTimer = false;
                ThirdTimer = false;
                FourthTimer = false;
                PlayerOneButton.interactable = true;
                PlayerTwoButton.interactable = true;
                buttonTimer.interactable = false;
            }

        }
    }

    public void DisableButton()
    {
        buttonNext.interactable = false;
        buttonTimer.interactable = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
