using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameScript : MonoBehaviour
{
    public string nameOfPlayer1;
    public string saveName1;
    public string nameOfPlayer2;
    public string saveName2;
    public string nameOfPlayer3;
    public string saveName3;
    public string nameOfPlayer4;
    public string saveName4;
    public string nameOfPlayer5;
    public string saveName5;
    public string nameOfPlayer6;
    public string saveName6;
    public string nameOfPlayer7;
    public string saveName7;
    public string nameOfPlayer8;
    public string saveName8;


    public Text inputText1;
    public Text loadedName1;
    public Text inputText2;
    public Text loadedName2;
    public Text inputText3;
    public Text loadedName3;
    public Text inputText4;
    public Text loadedName4;
    public Text inputText5;
    public Text loadedName5;
    public Text inputText6;
    public Text loadedName6;
    public Text inputText7;
    public Text loadedName7;
    public Text inputText8;
    public Text loadedName8;

    public GameObject avatarWindow;

    //public Image[] test;
    //public AvatarDatabase avatarTest;

    //string[] count = { "player1", "player2", "player3", "player4" };

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //nameOfPlayer1 = PlayerPrefs.GetString("name1", "none");
        //loadedName1.text = nameOfPlayer1;
        //nameOfPlayer2 = PlayerPrefs.GetString("name2", "none");
        //loadedName2.text = nameOfPlayer2;
        //nameOfPlayer3 = PlayerPrefs.GetString("name3", "none");
        //loadedName3.text = nameOfPlayer3;
        //nameOfPlayer4 = PlayerPrefs.GetString("name4", "none");
        //loadedName4.text = nameOfPlayer4;
        //nameOfPlayer5 = PlayerPrefs.GetString("name5", "none");
        //loadedName5.text = nameOfPlayer5;
        //nameOfPlayer6 = PlayerPrefs.GetString("name6", "none");
        //loadedName6.text = nameOfPlayer6;
        //nameOfPlayer7 = PlayerPrefs.GetString("name7", "none");
        //loadedName7.text = nameOfPlayer7;
        //nameOfPlayer8 = PlayerPrefs.GetString("name8", "none");
        //loadedName8.text = nameOfPlayer8;
    }

    public void SetName()
    {
        saveName1 = inputText1.text;
        PlayerPrefs.SetString("name1", saveName1);
        saveName2 = inputText2.text;
        PlayerPrefs.SetString("name2", saveName2);
        saveName3 = inputText3.text;
        PlayerPrefs.SetString("name3", saveName3);
        saveName4 = inputText4.text;
        PlayerPrefs.SetString("name4", saveName4);
        saveName5 = inputText5.text;
        PlayerPrefs.SetString("name5", saveName5);
        saveName6 = inputText6.text;
        PlayerPrefs.SetString("name6", saveName6);
        saveName7 = inputText7.text;
        PlayerPrefs.SetString("name7", saveName7);
        saveName8 = inputText8.text;
        PlayerPrefs.SetString("name8", saveName8);

    }

    public void openWindow()
    {
        avatarWindow.SetActive(true);
    }

    public void closeWindow()
    {
        avatarWindow.SetActive(false);
    }

    public void Button1()
    {
        AvatarManager.key = "player1";
    }
    public void Button2()
    {
        AvatarManager.key = "player2";
    }
    public void Button3()
    {
        AvatarManager.key = "player3";
    }
    public void Button4()
    {
        AvatarManager.key = "player4";
    }
    public void Button5()
    {
        AvatarManager.key = "player5";
    }
    public void Button6()
    {
        AvatarManager.key = "player6";
    }
    public void Button7()
    {
        AvatarManager.key = "player7";
    }
    public void Button8()
    {
        AvatarManager.key = "player8";
    }

    //public void TEST()
    //{
    //    for (int i = 0; i < PlayerPrefs.GetInt("NumOfPlayers"); i++)
    //    {
    //        Avatar avatar = avatarTest.GetAvatar(PlayerPrefs.GetInt(count[i]));
    //        test[i].sprite = avatar.playerAvatar;
    //        test[i].enabled = true;
    //    }
    //}
}
