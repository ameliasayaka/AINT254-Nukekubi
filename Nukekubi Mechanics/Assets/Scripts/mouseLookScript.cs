using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLookScript : MonoBehaviour {
    [SerializeField]
    [Range(0.1f,10.0f)]
    private float speed = 5.0f;


	// Update is called once per frame
	void FixedUpdate () {
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float hitDist = 0.0f;

        if (playerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        }
    }
}
