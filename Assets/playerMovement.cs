﻿using UnityEngine;

public class playerMovement : MonoBehaviour{


    public Rigidbody rb;
    public float forawardForce = 2000f;
    public float sideawaysForce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forawardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideawaysForce * Time.deltaTime, 0,0,ForceMode.VelocityChange);

        } 

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideawaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        /*if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forawardForce * Time.deltaTime);

        }*/

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forawardForce * Time.deltaTime);

        }

    }
}
