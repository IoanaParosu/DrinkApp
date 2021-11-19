using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarManager : MonoBehaviour
{
    public AvatarDatabase avatarDB;
    public Image avatarSprite;

    private int selectedOption = 0;

    public static string key;
    // Start is called before the first frame update
    void Start()
    {
        UpdateAvatar(selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = avatarDB.AvatarCount - 1;
        }

        UpdateAvatar(selectedOption);
        Save();
    }

    public void NextOption()
    {
        selectedOption++;
        if (selectedOption >= avatarDB.AvatarCount)
        {
            selectedOption = 0;
        }
        UpdateAvatar(selectedOption);
        Save();
    }

    private void UpdateAvatar(int selectedOption)
    {
        Avatar avatar = avatarDB.GetAvatar(selectedOption);
        avatarSprite.sprite = avatar.playerAvatar;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt(key);
    }

    private void Save()
    {
        PlayerPrefs.SetInt(key, selectedOption);
    }
}
