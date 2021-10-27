using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    [HideInInspector] public Text[] players;
    public Text[] playersOrdered;
    // Start is called before the first frame update
    void Start()
    {
        ShowResults();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowResults()
    {
        for(int i = 0; i < PlayerPrefs.GetInt("NumOfPlayers"); i++)
        {
            //players[i].text = PlayerPrefs.GetString(ChoosePlayers.constNames[i]) + " " + ChoosePlayers.scores[i];
            playersOrdered[i].text = PlayerPrefs.GetString(ChoosePlayers.constNames[i]) + " " + ChoosePlayers.scores[i] + "p";
            playersOrdered[i].gameObject.SetActive(true);
        }
    }

    public void PlayAgain()
    {
        ResetValues();

        ChangeScene.PlayScene();
    }

    public void NewGame()
    {
        ResetValues();
        ChangeScene.SetPlayersScene();
    }

    public void ResetValues()
    {
        for (int i = 0; i < ChoosePlayers.scores.Length; i++)
        {
            ChoosePlayers.scores[i] = 0;
        }

        ChoosePlayers.names = new List<string>()
        {
            "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8"
        };

        ChoosePlayers.usedNames = new List<string>()
        {
            "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8"
        };

        if (SetQuestion.usedRands.Count <= PlayerPrefs.GetInt("NumOfPlayers") * 2)
        {
            SetQuestion.usedRands = SetQuestion.constRands;
        }
    }
}
