using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {
    public GameObject gameOverCanvas;
    public GameObject startCanvas;
  
    private GameObject player;
    private Vector3 playerStartPosition;
    private movementScript playerMovementScript;
    private jumpScript playerJumpScript;


    // Use this for initialization
    void Start () {
        Time.timeScale = 0.0001f;
        player = GameObject.FindGameObjectWithTag("Player");
        playerStartPosition = player.transform.position;
        playerMovementScript = player.GetComponent<movementScript>();
        playerJumpScript = player.GetComponent<jumpScript>();
    }

    public void ClickExit()
    {
        Application.Quit();
    }

    public void ClickRestart()
    {
        // SceneManager.LoadScene("Level1");
        player.transform.position = playerStartPosition;
        gameOverCanvas.SetActive(false);
        playerMovementScript.enabled = true;
        playerJumpScript.enabled = true;
        Time.timeScale = 1f;
    }

    public void ClickStart()
    {
        startCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
