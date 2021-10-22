using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetQuestion : MonoBehaviour
{
    public GameObject[] questions;

    List<int> usedRands = new List<int>()
    {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 ,28, 29
    };

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

}