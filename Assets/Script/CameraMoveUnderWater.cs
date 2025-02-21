﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveUnderWater : MonoBehaviour
{
    [SerializeField]
    private Transform camera;
    [SerializeField]
    private float distToMove;

    [SerializeField]
    private float value;

    private Vector3 oldPosition;

    void Start()
    {
        oldPosition = camera.position;
    }

    void Update()
    {
        float diff = (camera.position - oldPosition).magnitude;
        Vector3 direction = (camera.position - oldPosition).normalized;
        if (diff > distToMove)
            transform.position += direction * (diff / value);

        oldPosition = camera.position;
    }
}
