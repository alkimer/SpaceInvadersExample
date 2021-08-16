using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletMovement : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private Vector2 movement;
    public float speed;

    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
  
    void FixedUpdate()
    {
        rigidbody.AddForce(movement * speed * 5f);
    }

    void Update()
    {
        movement = new Vector2(0f, speed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
   

    }
}