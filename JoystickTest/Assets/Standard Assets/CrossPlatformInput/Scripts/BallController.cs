﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BallController : MonoBehaviour
{

    Rigidbody rb;
    public float speed;
    // Start is called before the first frame update

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float hInput = CrossPlatformInputManager.GetAxis("Horizontal") * speed;
        float vInput = CrossPlatformInputManager.GetAxis("Vertical") * speed;

        rb.AddForce(hInput, 0, vInput);

    }
}
