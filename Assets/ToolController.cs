using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolController : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float rotationSpeed = 90.0f;

    private bool touchingMouth = false;
    private Rigidbody rb;

    private void Start()
    {


        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {

        float horizontalInput = Input.GetAxis("Mouse X");
        float verticalInput = Input.GetAxis("Mouse Y");
        float zInput = Input.GetAxis("Mouse ScrollWheel");


        // Calculate movement and rotation amounts
       // Vector3 movement = new Vector3(horizontalInput, verticalInput, zInput * 9) * moveSpeed * Time.deltaTime;
        //float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;


        Vector3 velocity = new Vector3(horizontalInput, verticalInput, zInput * 9) * 20 * Time.deltaTime;

         Debug.Log(horizontalInput);
        // Apply the velocity to the Rigidbody
        rb.velocity = velocity;



    }
    /* private void OnTriggerStay(Collider other)
     {

         if (other.CompareTag("Mouth"))
         {
            *//* Debug.Log("Touching InMouth");*//*
             // Stop movement when colliding with other objects
             //moveSpeed = 0f;
             //touchingMouth = true;

         }
         {
             *//*Debug.Log("Not Touching InMouth");*//*
             // Resume movement when no longer colliding
             //moveSpeed = this.moveSpeed;
             //touchingMouth = false;

         }

     }*/

    /*private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Mouth"))
        {
            Debug.Log("Touching InMouth");
            // Stop movement when colliding with other objects
            moveSpeed = 0f;
            touchingMouth = true;

        }
       
    }

    private void OnTriggerExit(Collider other)
    {

        if (!other.CompareTag("Mouth"))
        {
            Debug.Log("Not Touching InMouth");
            // Resume movement when no longer colliding
            moveSpeed = this.moveSpeed;
            touchingMouth = false;

        }
        
    }*/
}




