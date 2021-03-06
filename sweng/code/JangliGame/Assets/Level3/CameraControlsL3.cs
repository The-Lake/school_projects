﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlsL3 : MonoBehaviour
{

    public GameObject Player;       //Public variable to store a reference to the player game object
    public float maxLeft;
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera
    public GameObject Background;

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - Player.transform.position;
    }

    void Update()
    {
        if (Player.transform.position.x < maxLeft)
        {
            maxLeft = Player.transform.position.x;
        }
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        transform.position = new Vector3(maxLeft, Player.transform.position.y, Player.transform.position.z)
            + new Vector3(0, offset.y, offset.z);
    }
}