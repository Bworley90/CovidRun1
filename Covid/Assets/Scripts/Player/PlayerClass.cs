using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerClass : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    public int playerNumber;



    public void PlayerMovement()
    {
        if (Input.GetButton("Vertical") && Input.GetAxisRaw("Vertical") > 0) // Up
        {
            transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
        }
        else if (Input.GetButton("Vertical") && Input.GetAxisRaw("Vertical") < 0) //Down
        {
            transform.position = transform.position + Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") < 0) //Left
        {
            transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
        }
    }

    public void PlayerMovementWithRigidBody()
    {

        
        if (Input.GetButton("Vertical") && Input.GetAxisRaw("Vertical") > 0) // Up
        {
            GetComponent<Rigidbody2D>().AddForce(transform.position * Vector2.up * speed);
        }
        else if (Input.GetButton("Vertical") && Input.GetAxisRaw("Vertical") < 0) //Down
        {
            GetComponent<Rigidbody2D>().AddForce(transform.position * Vector2.down * speed);
        }
        if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") < 0) //Left
        {
            GetComponent<Rigidbody2D>().AddForce(transform.position * Vector2.left * speed);
        }
        else if (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") > 0) // Right
        {
            GetComponent<Rigidbody2D>().AddForce(transform.position * Vector2.right * speed);
        }
    }
}

