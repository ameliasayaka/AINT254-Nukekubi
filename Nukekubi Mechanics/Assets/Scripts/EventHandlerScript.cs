using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {
    public GameObject gameOverCanvas;
    public GameObject startCanvas;

    // Use this for initialization
    void Start () {
        Time.timeScale = 0.0001f;
    }

    public void ClickExit()
    {
        Application.Quit();
    }

    public void ClickRestart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ClickStart()
    {
        startCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
