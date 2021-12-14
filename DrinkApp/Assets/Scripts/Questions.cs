using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    public static string[] questionsText = new string[24];

    public string[] TypeOneQuestions = new string[24];
    public string[] TypeTwoQuestions = new string[24];
    public string[] TypeThreeQuestions = new string[24];
    public string[] TypeFourQuestions = new string[24];
    public string[] TypeFiveQuestions = new string[24];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TopicOne()
    {
        for (int i = 0; i < TypeOneQuestions.Length; i++)
        {
            questionsText[i] = TypeOneQuestions[i];
        }
    }

    public void TopicTwo()
    {
        for (int i = 0; i < TypeTwoQuestions.Length; i++)
        {
            questionsText[i] = TypeTwoQuestions[i];
        }
    }

    public void TopicThree()
    {
        for (int i = 0; i < TypeThreeQuestions.Length; i++)
        {
            questionsText[i] = TypeThreeQuestions[i];
        }
    }

    public void TopicFour()
    {
        for (int i = 0; i < TypeFourQuestions.Length; i++)
        {
            questionsText[i] = TypeFourQuestions[i];
        }
    }

    public void TopicFive()
    {
        for (int i = 0; i < TypeFiveQuestions.Length; i++)
        {
            questionsText[i] = TypeFiveQuestions[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
