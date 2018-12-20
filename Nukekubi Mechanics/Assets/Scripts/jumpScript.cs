using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScript : MonoBehaviour {

    private Transform m_objectTransform;

    private Rigidbody m_objectRigidbody;

    
    [SerializeField]
    [Range(0.1f, 200)]
    private float jumpForce = 5f;
    private Vector3 jump;

    [SerializeField]
    [Range(0.1f, 200)]
    private float jumpHeight = 2.0f;

	// Use this for initialization
	void Start () {
        m_objectTransform = transform;
        m_objectRigidbody = m_objectTransform.GetComponent<Rigidbody>();
        jump = new Vector3(0, jumpHeight);


	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey(KeyCode.Space))
        {
            m_objectRigidbody.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
    }
}
