using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerClass : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    public int playerNumber;
    private Vector3 movementDirection;


    public void PlayerMovement()
    {
        movementDirection = Vector2.zero;
        movementDirection.x = Input.GetAxisRaw("Horizontal");
        movementDirection.y = Input.GetAxisRaw("Vertical");
        if(movementDirection != Vector3.zero)
        {
            movementDirection.Normalize();
            GetComponent<Rigidbody2D>().MovePosition(transform.position + movementDirection * speed * Time.deltaTime);
        }
    }

    
}

