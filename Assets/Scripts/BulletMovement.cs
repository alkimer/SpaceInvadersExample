using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BulletMovement : MonoBehaviour
{
  //  private new Rigidbody2D rigidbody;
    private Vector2 movement;
    public float speed;

    
    void Start()
    {
      //  rigidbody = GetComponent<Rigidbody2D>();
    }
  
    void FixedUpdate()
    {
        movement = new Vector2(0f, speed);
        Move(movement);   
        
    }

    void Update()
    {
 

    }

    private void Move(Vector2 movement)
    {
        Vector2 pos = transform.position;
        
        pos += movement * speed * Time.deltaTime;
        transform.position = pos;
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("ZZZZZZZZZZZZZZZZZZZZZZ:" + col.gameObject.name);


    }
}