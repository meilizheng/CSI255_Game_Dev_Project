using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Slime_01 : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    private float horizontalInput;
    private float verticalInput;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Moves the charactor forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Rotates the charactor base on the horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
