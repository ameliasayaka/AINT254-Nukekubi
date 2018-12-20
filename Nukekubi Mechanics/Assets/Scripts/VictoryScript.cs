using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScript : MonoBehaviour {

    private GameObject playerObject;
    public GameObject victoryCanvas;
    private movementScript moveScript;
    // Use this for initialization
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        moveScript = playerObject.GetComponent<movementScript>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
                Time.timeScale = 0.0001f;
                victoryCanvas.SetActive(true);
        
        }

    }
}
