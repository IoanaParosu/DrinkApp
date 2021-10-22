using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOfPlayers : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> gameObjects = new List<GameObject>()
    {

    };

    public List<GameObject> InputFields = new List<GameObject>()
    {

    };
    public static int ChosenNumberOfPlayers;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TwoPlayers()
    {
        ChosenNumberOfPlayers = 2;
        PlayerPrefs.SetInt("NumOfPlayers", ChosenNumberOfPlayers);
        ArrangeGameObjects();
        for(int i = 0; i < ChosenNumberOfPlayers; i++)
        {
            InputFields[i].SetActive(true);
        }
    }

    public void ThreePlayers()
    {
        ChosenNumberOfPlayers = 3;
        PlayerPrefs.SetInt("NumOfPlayers", ChosenNumberOfPlayers);
        ArrangeGameObjects();
        for (int i = 0; i < ChosenNumberOfPlayers; i++)
        {
            InputFields[i].SetActive(true);
        }
    }

    public void FourPlayers()
    {
        ChosenNumberOfPlayers = 4;
        PlayerPrefs.SetInt("NumOfPlayers", ChosenNumberOfPlayers);
        ArrangeGameObjects();
        for (int i = 0; i < ChosenNumberOfPlayers; i++)
        {
            InputFields[i].SetActive(true);
        }
    }

    public void FivePlayers()
    {
        ChosenNumberOfPlayers = 5;
        PlayerPrefs.SetInt("NumOfPlayers", ChosenNumberOfPlayers);
        ArrangeGameObjects();
        for (int i = 0; i < ChosenNumberOfPlayers; i++)
        {
            InputFields[i].SetActive(true);
        }
    }

    public void SixPlayers()
    {
        ChosenNumberOfPlayers = 6;
        PlayerPrefs.SetInt("NumOfPlayers", ChosenNumberOfPlayers);
        ArrangeGameObjects();
        for (int i = 0; i < ChosenNumberOfPlayers; i++)
        {
            InputFields[i].SetActive(true);
        }
    }

    public void SevenPlayers()
    {
        ChosenNumberOfPlayers = 7;
        PlayerPrefs.SetInt("NumOfPlayers", ChosenNumberOfPlayers);
        ArrangeGameObjects();
        for (int i = 0; i < ChosenNumberOfPlayers; i++)
        {
            InputFields[i].SetActive(true);
        }
    }

    public void EightPlayers()
    {
        ChosenNumberOfPlayers = 8;
        PlayerPrefs.SetInt("NumOfPlayers", ChosenNumberOfPlayers);
        ArrangeGameObjects();
        for (int i = 0; i < ChosenNumberOfPlayers; i++)
        {
            InputFields[i].SetActive(true);
        }
    }

    public void ArrangeGameObjects()
    {
        //disable or enable gameobjects after we choose the number of players

        for(int i = 0; i < gameObjects.Count - 1; i++)
        {
            gameObjects[i].SetActive(false);
        }
        gameObjects[gameObjects.Count - 1].SetActive(true);
    }
}
