using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosePlayers : MonoBehaviour
{
    public string ChosenPlayer1;
    public string ChosenPlayer2;

    List<string> names = new List<string>()
    {
        "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8"
    };

    public Text loadPlayer1Text;
    public Text loadPlayer2Text;
    public Text rounds;
    public Button PlayerButtonOne;
    public Button PlayerButtonTwo;
    public Button buttonNext;

    List<string> usedNames = new List<string>()
    {
        "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8"
    };

    List<string> constNames = new List<string>()
    {
        "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8"
    };

    int random1 = 0;
    int random2 = 0;
    [HideInInspector] public int[] scores;

    // Start is called before the first frame update
    void Start()
    {
        scores = new int[PlayerPrefs.GetInt("NumOfPlayers")];
        for(int i = 0; i < scores.Length; i++)
        {
            scores[i] = 0;
        }
        for (int i = PlayerPrefs.GetInt("NumOfPlayers"); i < 8; i++)
        {
            names.RemoveAt(PlayerPrefs.GetInt("NumOfPlayers"));
            usedNames.RemoveAt(PlayerPrefs.GetInt("NumOfPlayers"));
        }
        ChoosingPlayers();
    }

    public void ChoosingPlayers()
    {

        if (names.Count > 0)
        {
            rounds.text = "Round 1";
            random1 = Random.Range(0, names.Count - 1);
            ChosenPlayer1 = names[random1];
            loadPlayer1Text.text = PlayerPrefs.GetString(ChosenPlayer1);
            names.RemoveAt(random1);
            random2 = Random.Range(0, names.Count - 1);
            ChosenPlayer2 = names[random2];
            loadPlayer2Text.text = PlayerPrefs.GetString(ChosenPlayer2);
            names.RemoveAt(random2);
        }
        else
        {
            rounds.text = "Round 2";
            random1 = Random.Range(0, usedNames.Count - 1);
            ChosenPlayer1 = usedNames[random1];
            loadPlayer1Text.text = PlayerPrefs.GetString(ChosenPlayer1);
            usedNames.RemoveAt(random1);
            random2 = Random.Range(0, usedNames.Count - 1);
            ChosenPlayer2 = usedNames[random2];
            loadPlayer2Text.text = PlayerPrefs.GetString(ChosenPlayer2);
            usedNames.RemoveAt(random2);
        }
    }

    public void Vote1()
    {
        for(int i = 0; i < PlayerPrefs.GetInt("NumOfPlayers"); i++)
        {
            if(ChosenPlayer1 == constNames[i])
            {
                scores[i]++;
            }
        }

        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log(scores[i]);
        }
        PlayerButtonOne.interactable = false;
        PlayerButtonTwo.interactable = false;
        buttonNext.interactable = true;
    }
    public void Vote2()
    {
        for (int i = 0; i < PlayerPrefs.GetInt("NumOfPlayers"); i++)
        {
            if (ChosenPlayer2 == constNames[i])
            {
                scores[i]++;
            }
        }
        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log(scores[i]);
        }
        PlayerButtonOne.interactable = false;
        PlayerButtonTwo.interactable = false;
        buttonNext.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
