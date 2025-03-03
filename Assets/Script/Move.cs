﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.up * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position -= Vector3.up * speed * Time.deltaTime;
    }
}
