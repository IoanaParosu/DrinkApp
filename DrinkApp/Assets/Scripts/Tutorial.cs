using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TutorialBox()
    {
        if(!box.activeInHierarchy)
        {
            box.SetActive(true);
        }

        else
        {
            box.SetActive(false);
        }
    }
}
