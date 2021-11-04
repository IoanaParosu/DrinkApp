using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetQuestion : MonoBehaviour
{
    public GameObject[] questions;

    [HideInInspector] public static List<int> usedRands = new List<int>()
    {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 ,28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47
    };

    [HideInInspector] public static List<int> constRands = new List<int>()
    {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 ,28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47
    };

    public GameObject For;
    public GameObject Against;

    int random = 0;
    int temp = 0;
    // Start is called before the first frame update
    void Start()
    {
        ChooseQuestion();
    }

    public void ChooseQuestion()
    {
        questions[temp].SetActive(false);
        random = Random.Range(0, usedRands.Count - 1);
        //Debug.Log(random);
        questions[usedRands[random]].SetActive(true);
        temp = usedRands[random];
        usedRands.RemoveAt(random);
        //Debug.Log(usedRands.Count);

        //for (int i = 0; i < usedRands.Count; i++)
        //{
        //    Debug.Log(usedRands[i]);
        //}
    }

    private void Update()
    {
        for(int i = 0; i < questions.Length; i++)
        {
            if(questions[i].activeInHierarchy)
            {
                if(i <= 12)
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
