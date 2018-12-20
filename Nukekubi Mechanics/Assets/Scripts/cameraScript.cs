using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {
    private GameObject player;
    private Transform playerTransform;
    private Vector3 offset;
    private float rotationAngle;
    private Quaternion rotation;
    private float horizontalPosition;
    private Vector3 cameraPos;
    private LayerMask wallLayer;
    private RaycastHit ray;
    private float clipOffset = 0.1f;
    private Vector3 clipCheckOffset;
    private Vector3 currentOffset;


    [SerializeField]
    private float rotateSpeed = 1;
    private float smooth = 4f;

    
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;
       
        clipCheckOffset = new Vector3(0, 1, 0);
        offset = playerTransform.position - transform.position;
        currentOffset = offset;
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentOffset = offset * 0.3f;

        if (currentOffset.x < 1)
        {
            currentOffset.x = 1;
        }
        if(currentOffset.y < 1)
        {
            currentOffset.y = 1;
        }
        if (currentOffset.z < 1)
        {
            currentOffset.z = 1;
        }
    }


    // Update is called once per frame
    void LateUpdate () {
        horizontalPosition = Input.GetAxis("Mouse X") * rotateSpeed;
        playerTransform.Rotate(0, horizontalPosition, 0);

        rotationAngle = playerTransform.eulerAngles.y;
        rotation = Quaternion.Euler(0, rotationAngle, 0);
        cameraPos = transform.position;
        currentOffset = Vector3.Slerp(currentOffset, offset, 0.5f);

        transform.position = Vector3.Lerp(cameraPos, playerTransform.position - (rotation * currentOffset), 0.1f);

      
        transform.LookAt(playerTransform);

        
     }



}
