using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetQuestion : MonoBehaviour
{
    public Text[] questions;

    [HideInInspector] public static List<int> usedRands = new List<int>()
    {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23
    };

    [HideInInspector] public static List<int> constRands = new List<int>()
    {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23
    };

    public GameObject For;
    public GameObject Against;

    int random = 0;
    int temp = 0;
    // Start is called before the first frame update
    void Start()
    {
        setQuestionsText();
        ChooseQuestion();
    }

    public void ChooseQuestion()
    {
        for(int i = 0; i < questions.Length; i++)
        {
            Debug.Log(questions[i].text);
        }
        questions[temp].gameObject.SetActive(false);
        random = Random.Range(0, usedRands.Count - 1);
        questions[usedRands[random]].gameObject.SetActive(true);
        temp = usedRands[random];
        usedRands.RemoveAt(random);
    }

    public void setQuestionsText()
    {
        for(int i = 0; i < questions.Length; i++)
        {
            questions[i].text = Questions.questionsText[i];
        }
    }

    private void Update()
    {
        for(int i = 0; i < questions.Length; i++)
        {
            if(questions[i].gameObject.activeInHierarchy)
            {
                if(i >= 12)
                {
                    For.SetActive(true);
                    Against.SetActive(true);
                }

                else
                {
                    For.SetActive(false);
                    Against.SetActive(false);
                }
            }
        }
    }

}
