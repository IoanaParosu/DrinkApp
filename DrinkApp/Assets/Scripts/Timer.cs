using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int countDownStartValue = 30;

    public Text timerText;
    bool FirstTimer;
    bool SecondTimer;
    bool ThirdTimer;
    bool FourthTimer;

    public Button buttonTimer;
    public Button buttonNext;

    // Start is called before the first frame update
    void Start()
    {
        FirstTimer = true;
        SecondTimer = false;
        ThirdTimer = false;
        FourthTimer = false;
    }

    public void countDownTimer()
    {
        if(countDownStartValue > 0)
        {
            buttonTimer.interactable = false;
            buttonNext.interactable = false;
            timerText.text = "" + countDownStartValue;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            buttonTimer.interactable = true;
            timerText.text = "";
            if(FirstTimer && !SecondTimer && !ThirdTimer && !FourthTimer)
            {
                countDownStartValue = 30;
                FirstTimer = false;
                SecondTimer = true;
                ThirdTimer = false;
                FourthTimer = false;
            }
            else if(!FirstTimer && SecondTimer && !ThirdTimer && !FourthTimer)
            {
                countDownStartValue = 15;
                FirstTimer = false;
                SecondTimer = false;
                ThirdTimer = true;
                FourthTimer = false;
            }
            else if(!FirstTimer && !SecondTimer && ThirdTimer && !FourthTimer)
            {
                countDownStartValue = 15;
                FirstTimer = false;
                SecondTimer = false;
                ThirdTimer = false;
                FourthTimer = true;
            }
            else if(!FirstTimer && !SecondTimer && !ThirdTimer && FourthTimer)
            {
                countDownStartValue = 30;
                FirstTimer = true;
                SecondTimer = false;
                ThirdTimer = false;
                FourthTimer = false;
                buttonNext.interactable = true; 
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
