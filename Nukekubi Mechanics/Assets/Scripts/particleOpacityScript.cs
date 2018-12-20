using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleOpacityScript : MonoBehaviour {

    private ParticleSystem particles;
    private float distance;
    private Transform goal;
    private Transform player;

    private float opacityAmount;
	// Use this for initialization
	void Start () {
        particles = GetComponent<ParticleSystem>();
        goal = GameObject.FindGameObjectWithTag("Goal").transform;
        player = transform;
        
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(player.position, goal.position);
        opacityAmount = 1/distance;

        if (opacityAmount < 0 )
        {
            opacityAmount = 0;
        }

        var main = particles.main;
        main.startColor = new Color(1.0f, 0.0f, 0.0f, opacityAmount);
	}
}
