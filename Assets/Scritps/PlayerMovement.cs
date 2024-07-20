using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MoveSpeed  = 10f;
    private Rigidbody2D RB;
    private Vector2 movement;
    public LayerMask ObstacleMask;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

    }

    void FixedUpdate()
    {
        Vector2 newPosition = RB.position + MoveSpeed * movement * Time.deltaTime;
        RB.MovePosition(newPosition);
    }
}
