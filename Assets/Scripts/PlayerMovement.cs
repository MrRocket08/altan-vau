using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 5f;
    
    private float verticalSpeed = 0;
    private float horizontalSpeed = 0;
    private Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalSpeed = Input.GetAxis("Vertical");
        horizontalSpeed = Input.GetAxis("Horizontal");
        
        movement = new Vector2(horizontalSpeed, verticalSpeed).normalized;
        
        transform.Translate(movementSpeed * movement * Time.deltaTime);
    }
}
