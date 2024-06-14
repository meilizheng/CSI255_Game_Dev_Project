using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    // Declare Rigid Body
    Rigidbody rb;
    public float jumpForce;
    public float zRange = 6.0f;

    public float jumpSpeed = 20;


    // Start is called before the first frame update
    void Start()
    {
        // Get the Component - RigidBody - of the current Object
        rb = GetComponent<Rigidbody>();
        jumpForce = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if(Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Is Jumping");
            Flap();
        }

        if (transform.position.y < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

    } // End of Update

    public void Flap() { 
            rb.AddForce(Vector3.up * jumpForce * jumpSpeed, ForceMode.Impulse);
    }
}
