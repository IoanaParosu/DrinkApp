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

    List<string> usedNames = new List<string>()
    {
        "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8"
    };

    int random = 0;

    // Start is called before the first frame update
    void Start()
    {
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
            random = Random.Range(0, names.Count - 1);
            ChosenPlayer1 = names[random];
            loadPlayer1Text.text = PlayerPrefs.GetString(ChosenPlayer1);
            names.RemoveAt(random);
            random = Random.Range(0, names.Count - 1);
            ChosenPlayer2 = names[random];
            loadPlayer2Text.text = PlayerPrefs.GetString(ChosenPlayer2);
            names.RemoveAt(random);
        }
        else
        {
            random = Random.Range(0, usedNames.Count - 1);
            ChosenPlayer1 = usedNames[random];
            loadPlayer1Text.text = PlayerPrefs.GetString(ChosenPlayer1);
            usedNames.RemoveAt(random);
            random = Random.Range(0, usedNames.Count - 1);
            ChosenPlayer2 = usedNames[random];
            loadPlayer2Text.text = PlayerPrefs.GetString(ChosenPlayer2);
            usedNames.RemoveAt(random);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
