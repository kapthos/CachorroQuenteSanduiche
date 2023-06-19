using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string LevelName;

    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelName);
    }

    public void QuiteGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
