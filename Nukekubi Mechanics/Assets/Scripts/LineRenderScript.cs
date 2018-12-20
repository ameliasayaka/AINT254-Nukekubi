using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderScript : MonoBehaviour {

    private LineRenderer lineRenderer;
    private GameObject player;
    private Transform playerTransform;
    private Vector3 playerPosition;

	// Use this for initialization
	void Start () {
        lineRenderer = GetComponent<LineRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;
      
	}
	
	// Update is called once per frame
	void Update () {
        playerPosition = playerTransform.position;
        lineRenderer.SetPosition(1,playerPosition);
	}
}
