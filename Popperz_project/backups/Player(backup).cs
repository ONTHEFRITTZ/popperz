using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidBodyComponent;
    private bool isGrounded;


    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
    }

// Update is called once per frame
    void Update()
    {
        //movement controls
        if (Input.GetKeyDown(KeyCode.Space))
			{
                jumpKeyWasPressed = true;
			}
        
        horizontalInput = Input.GetAxis("Horizontal");
       

    
    }  

//Fixed update is called once every physics update

private void FixedUpdate()
    {
        if (isGrounded)
        {
            return;
        }
    
        if (jumpKeyWasPressed)
			{
                rigidBodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
                jumpKeyWasPressed = false;
			}

            rigidBodyComponent.velocity = new Vector3(horizontalInput * 3, rigidBodyComponent.velocity.y, 0);
    }


    }

}
