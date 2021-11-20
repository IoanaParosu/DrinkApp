using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosePlayers : MonoBehaviour
{
    public string ChosenPlayer1;
    public string ChosenPlayer2;

    [HideInInspector] public static List<string> names = new List<string>()
    {
        "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8"
    };

    public Text loadPlayer1Text;
    public Text loadPlayer2Text;
    public Text rounds;
    public Button PlayerButtonOne;
    public Button PlayerButtonTwo;
    public Button buttonNext;
    public Image[] avatarImage;
    public AvatarDatabase avatarDB;

    List <string> holder = new List<string>() 
    { 
        "player1", "player2", "player3", "player4", "player5", "player6", "player7", "player8" 
    };

    public static List<string> usedNames = new List<string>()
    {
        "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8"
    };

    public static List<string> constNames = new List<string>()
    {
        "name1", "name2", "name3", "name4", "name5", "name6", "name7", "name8"
    };

    int random1 = 0;
    int random2 = 0;
    [HideInInspector] public static int[] scores;

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

        if (names.Count < 1 && usedNames.Count < 1)
        {
            ChangeScene.ResultsScene();
        }
        else
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

        Test();
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

    public void Test()
    {
        if (loadPlayer1Text.text == PlayerPrefs.GetString("name1"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player1"));
            avatarImage[0].sprite = avatar.playerAvatar;
        }

        if (loadPlayer2Text.text == PlayerPrefs.GetString("name1"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player1"));
            avatarImage[1].sprite = avatar.playerAvatar;
        }
        if (loadPlayer1Text.text == PlayerPrefs.GetString("name2"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player2"));
            avatarImage[0].sprite = avatar.playerAvatar;
        }
        if (loadPlayer2Text.text == PlayerPrefs.GetString("name2"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player2"));
            avatarImage[1].sprite = avatar.playerAvatar;
        }
        if (loadPlayer1Text.text == PlayerPrefs.GetString("name3"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player3"));
            avatarImage[0].sprite = avatar.playerAvatar;
        }
        if (loadPlayer2Text.text == PlayerPrefs.GetString("name3"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player3"));
            avatarImage[1].sprite = avatar.playerAvatar;
        }
        if (loadPlayer1Text.text == PlayerPrefs.GetString("name4"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player4"));
            avatarImage[0].sprite = avatar.playerAvatar;
        }
        if (loadPlayer2Text.text == PlayerPrefs.GetString("name4"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player4"));
            avatarImage[1].sprite = avatar.playerAvatar;
        }
        if (loadPlayer1Text.text == PlayerPrefs.GetString("name5"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player5"));
            avatarImage[0].sprite = avatar.playerAvatar;
        }
        if (loadPlayer2Text.text == PlayerPrefs.GetString("name5"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player5"));
            avatarImage[1].sprite = avatar.playerAvatar;
        }
        if (loadPlayer1Text.text == PlayerPrefs.GetString("name6"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player6"));
            avatarImage[0].sprite = avatar.playerAvatar;
        }
        if (loadPlayer2Text.text == PlayerPrefs.GetString("name6"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player6"));
            avatarImage[1].sprite = avatar.playerAvatar;
        }
        if (loadPlayer1Text.text == PlayerPrefs.GetString("name7"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player7"));
            avatarImage[0].sprite = avatar.playerAvatar;
        }
        if (loadPlayer2Text.text == PlayerPrefs.GetString("name7"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player7"));
            avatarImage[1].sprite = avatar.playerAvatar;
        }
        if (loadPlayer1Text.text == PlayerPrefs.GetString("name8"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player8"));
            avatarImage[0].sprite = avatar.playerAvatar;
        }
        if (loadPlayer2Text.text == PlayerPrefs.GetString("name8"))
        {
            Avatar avatar = avatarDB.GetAvatar(PlayerPrefs.GetInt("player8"));
            avatarImage[1].sprite = avatar.playerAvatar;
        }
    }
}
