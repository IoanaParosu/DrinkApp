using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    public Transform entryContainer;
    public Transform entryTemplate;
    private List<HighScoreEntry> highScoreEntryList;
    private List<Transform> highScoreEntryTransformList;
    // Start is called before the first frame update
    void Awake()
    {
        //entryContainer = transform.Find("highScoreContainer");
        //entryTemplate = entryContainer.Find("highScoreTemplate");

        //entryTemplate.gameObject.SetActive(false);

        highScoreEntryList = new List<HighScoreEntry>()
        {
            
        };

        for(int i = 0; i < PlayerPrefs.GetInt("NumOfPlayers"); i++)
        {
            highScoreEntryList.Add(new HighScoreEntry { score = ChoosePlayers.scores[i], name = PlayerPrefs.GetString(ChoosePlayers.constNames[i]) });
        }

        for(int i = 0; i < highScoreEntryList.Count; i++)
        {
            for(int j = i + 1; j < highScoreEntryList.Count; j++)
            {
                if(highScoreEntryList[j].score > highScoreEntryList[i].score)
                {
                    HighScoreEntry temp = highScoreEntryList[i];
                    highScoreEntryList[i] = highScoreEntryList[j];
                    highScoreEntryList[j] = temp;
                }
            }
        }

        highScoreEntryTransformList = new List<Transform>();
        foreach(HighScoreEntry highScoreEntry in highScoreEntryList)
        {
            createHighScoreEntryTransform(highScoreEntry, entryContainer, highScoreEntryTransformList);
        }
    }

    private void createHighScoreEntryTransform(HighScoreEntry highScoreEntry, Transform container, List<Transform> transformList)
    {
        float templateHeight = 20f;
        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);

        int rank = transformList.Count + 1;
        string rankString;
        switch(rank)
        {
            default: rankString = rank + "TH";
                break;

            case 1: rankString = "1ST"; break;
            case 2: rankString = "2ND"; break;
            case 3: rankString = "3RD"; break;
        }

        entryTransform.Find("posText").GetComponent<Text>().text = rankString;

        int score = highScoreEntry.score;

        entryTransform.Find("scoreText").GetComponent<Text>().text = score.ToString();

        string name = highScoreEntry.name;

        entryTransform.Find("nameText").GetComponent<Text>().text = name;

        transformList.Add(entryTransform);
    }

    private class HighScoreEntry
    {
        public int score;
        public string name;
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

    public void QuitGame()
    {
        Application.Quit();
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

    private class highScore
    {
        public int score;
        public string name;
    }
}
