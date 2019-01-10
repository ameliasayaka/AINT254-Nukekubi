using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attractScript : MonoBehaviour {

    private Transform playerObjectTransform;
    private Rigidbody playerObjectRigidbody;
    private Vector3 linePos1;
    private Vector3 direction;
    private bool inField;
    private float distance;
    private LineRenderer lineRenderer;

    [SerializeField]
    [Range(0.1f, 10f)]
    private float attractForce;

    [SerializeField]
    private bool isAttract = true;

    private int attractOrRepel;
    
        

    
	// Use this for initialization
	void Start () {
        playerObjectTransform = GameObject.FindGameObjectWithTag("Player").transform;
        playerObjectRigidbody = playerObjectTransform.GetComponent<Rigidbody>();
        inField = false;
        lineRenderer = GameObject.FindGameObjectWithTag("Line").GetComponent<LineRenderer>();
        linePos1 = transform.position;

        //sets whether cube is an attract or repel cube
        if (isAttract)
        {
            attractOrRepel = 1;
        }
        else
        {
            attractOrRepel = -1;
        }
        
	}
    private void OnTriggerEnter(Collider other)
    {
        inField = true;
        lineRenderer.enabled = true;
        lineRenderer.SetPosition(0, linePos1);
    }

    private void OnTriggerExit(Collider other)
    {
        inField = false;
        lineRenderer.enabled = false;
    }
    // Update is called once per frame
    void FixedUpdate () {
		if (inField)
        {
            direction = transform.position - playerObjectTransform.position;
            distance = Vector3.Distance(playerObjectTransform.position, transform.position);
            
            playerObjectRigidbody.AddForce(direction * attractForce * attractOrRepel * 1/distance);
        }
	}
}
