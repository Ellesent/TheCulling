﻿using UnityEngine;
using System.Collections;

public class andrewWolfScript : MonoBehaviour {

    public GameObject target; //the gameobject that the sheep will run towards.
    public float speed;
    public bool isChasing;
    private Rigidbody rb;
    private float currentSpeed;
    public float speedThreshold;
    public float sideJumpForce;
    public float sideFriction;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (isChasing)
        {
            currentSpeed = rb.velocity.magnitude;
            transform.LookAt(target.transform);
            rb.AddRelativeForce(Vector3.forward);

            if (rb.velocity.magnitude > speedThreshold)
            {
                //rb.velocity = new Vector3(transform.forward.x * currentSpeed, transform.forward.y * currentSpeed, transform.forward.z * currentSpeed);
            }

            //side velocity dampner
           // Debug.Log(rb.velocity.z);
            //if we have velocity to the right
            /*
            if (rb.velocity.z > 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z - sideFriction);
            }
            if (rb.velocity.z < 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z + sideFriction);
            }
            */
            // dampen it

            //if we have velocity to the left
            //dampen it


        }
    }

    void OnCollisionEnter()
    {
        Debug.Log("CollisionEnter");
        rb.AddRelativeForce(Vector3.left * sideJumpForce);
    }
    void OnTriggerEnter()
    {
        Debug.Log("Trigger");
    }
}
