using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
  public static void SetPlayersScene()
    {
        SceneManager.LoadScene("SetPlayersScene");
    }

    public static void PlayScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public static void ResultsScene()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
