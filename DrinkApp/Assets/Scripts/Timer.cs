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

    float time = 1f;
    public bool paused = false;

    public GameObject pauseButton;
    public GameObject resumeButton;

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
            if(!paused)
            {
                countDownStartValue--;
            }
            Invoke("countDownTimer", time);
        }
        else
        {
            AudioManager.instance.Stop("Clock");
            AudioManager.instance.Play("Bell");
            buttonTimer.interactable = true;
            timerText.text = "";
            time = 1.0f;
            if(FirstTimer && !SecondTimer && !ThirdTimer && !FourthTimer)
            {
                countDownStartValue = 40;
                FirstTimer = false;
                SecondTimer = true;
                ThirdTimer = false;
                FourthTimer = false;
            }
            else if(!FirstTimer && SecondTimer && !ThirdTimer && !FourthTimer)
            {
                countDownStartValue = 20;
                FirstTimer = false;
                SecondTimer = false;
                ThirdTimer = true;
                FourthTimer = false;
            }
            else if(!FirstTimer && !SecondTimer && ThirdTimer && !FourthTimer)
            {
                countDownStartValue = 20;
                FirstTimer = false;
                SecondTimer = false;
                ThirdTimer = false;
                FourthTimer = true;
            }
            else if(!FirstTimer && !SecondTimer && !ThirdTimer && FourthTimer)
            {
                countDownStartValue = 40;
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

    public void SkipTimer()
    {
        time = 0.1f;
        AudioManager.instance.Stop("Clock");
    }

    public void PauseTimer()
    {
        paused = true;
        AudioManager.instance.SetVolume("Clock", 0);
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
    }

    public void ResumeTimer()
    {
        paused = false;
        AudioManager.instance.SetVolume("Clock", 0.165f);
        resumeButton.SetActive(false);
        pauseButton.SetActive(true);
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
