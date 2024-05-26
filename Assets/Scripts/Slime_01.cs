using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Slime_01 : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    private float horizontalInput;
    private float verticalInput;

    public float xRange = 8.0f;

    public float yRange = 6.0f;

   
 
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) 
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z < -yRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -yRange);
        }
        if(transform.position.z > yRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, yRange);
        }
      


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Moves the charactor forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Rotates the charactor base on the horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
