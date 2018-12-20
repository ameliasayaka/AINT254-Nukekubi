using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {

    private Transform m_objectTransform;
    private Rigidbody m_objectRigidbody;

    [SerializeField]
    [Range(0.1f,10f)]
    private float speed = 2f;
	// Use this for initialization
	void Start () {
        m_objectTransform = transform;
        m_objectRigidbody = m_objectTransform.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.A))
        {
            m_objectRigidbody.AddForce(-m_objectTransform.right * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_objectRigidbody.AddForce(m_objectTransform.right * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            m_objectRigidbody.AddForce(m_objectTransform.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_objectRigidbody.AddForce(-m_objectTransform.forward * speed);
        }
	}
}
