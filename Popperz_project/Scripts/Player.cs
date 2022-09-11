using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform cameraFollow;
    [SerializeField] private Transform groundCheckTransform;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidBodyComponent;
    private GameObject Rigidbody;
    public float xAngle, yAngle, zAngle;



    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        rigidBodyComponent.transform.position = new Vector3(-0.75f, 0.0f, 0.0f);
        rigidBodyComponent.transform.Rotate(0.0f, 0.0f, 0.0f, Space.World);
        rigidBodyComponent.name = "World";
        
    }

// Update is called once per frame
    void Update()
    {
       
    }  

//Fixed update is called once every physics update

private void FixedUpdate()
    {

 //movement controls
        if (Input.GetKeyDown(KeyCode.Space))
			{
                jumpKeyWasPressed = true;
			}
        
        float horizontalInput = Input.GetAxis("Horizontal");

        rigidBodyComponent.velocity = new Vector3(horizontalInput * 3, rigidBodyComponent.velocity.y, 0);
    
        rigidBodyComponent.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
         
         if (Input.GetKeyDown(KeyCode.a))
			{
                leftWasPressed = true;
            }
    
    
        if (jumpKeyWasPressed)
			{
                rigidBodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
                jumpKeyWasPressed = false;
			}

           
    }       



}
