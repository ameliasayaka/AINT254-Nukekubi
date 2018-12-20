using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverScript : MonoBehaviour {
    
    private GameObject playerObject;
    public GameObject gameOverCanvas;
    private movementScript moveScript;
    private jumpScript jumpScript;
	// Use this for initialization
	void Start () {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        moveScript = playerObject.GetComponent<movementScript>();
        jumpScript = playerObject.GetComponent<jumpScript>();
     
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.CompareTag("Player"))
        {
            moveScript.enabled = false;
            jumpScript.enabled = false;
            
            if (gameObject.CompareTag("Floor"))
            {
                Time.timeScale = 0.0001f;
                gameOverCanvas.SetActive(true);
            }
        }
        
    }
 
}
