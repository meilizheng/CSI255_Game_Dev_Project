using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    // Declare Rigid Body
    Rigidbody rb;
    public float jumpForce;

    public float jumpSpeed = 50;


    // Start is called before the first frame update
    void Start()
    {
        // Get the Component - RigidBody - of the current Object
        rb = GetComponent<Rigidbody>();
        jumpForce = 100;
    }

    // Update is called once per frame
    void Update()
    {
        // AddForce imparts X amount of force in a direction on our object
        // Vector3 x, y ,z - 0, 1, 0

        // Space
        // When I click space, the ball bounces up
        // Input.GetButtonDown(string) - Input Manager
        // Triggers when the button is pressed. Just once
        // "Jump" - 
        // Godot Tip : In Godot the equilviant is Input.IsActionJustPressed
        if(Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Is Jumping");
            Flap();
        }

    } // End of Update

    public void Flap() {
            // Add force applie force in a particular direction
            // SECOND ARGUMENT
            // How to distribute that force
            rb.AddForce(Vector3.up * jumpForce * jumpSpeed, ForceMode.Impulse);
    }
}
