﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
    
    bool move = false;
    bool isGrounded = false;
    public Rigidbody2D rb;

    public float speed = 20f;
    public float rotationSpeed = 7f;
	// Update is called once per frame
	private void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            move = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            move = false;
        }
    }
    private void FixedUpdate()
    {
        if(move == true)
        {
            if (isGrounded == true)
            {
                rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
            else
            {
                rb.AddTorque(rotationSpeed * Time.fixedDeltaTime *100f, ForceMode2D.Force);
            }


         }
    }

    private void OnCollisionEnter2D()
    {
        isGrounded = true;
    }
    private void OnCollisionExit2D()
    {
        isGrounded = false;
    }


}
