/*
    Script for player movement and rotation
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMovement : MonoBehaviour
{
    public float speed;

    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        //Vector3 movementDirection = new Vector3(horizontalInput, verticalInput, 0);
        //Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            //Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);3
            Quaternion toRotation = Quaternion.LookRotation(Vector3.up, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            //speed += 0.1f; //0.01f
            
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            //transform.forward = movementDirection;


            if (Input.GetKey("left shift"))
            {
            speed += 0.07f; //8f; //20
            }
            else
            {
                speed = 4f; //12
            }
        }

        // else 
        // {
        //     speed = 4f;
        // }
 
    }
}
