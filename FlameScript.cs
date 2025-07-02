using UnityEngine;
using UnityEngine.InputSystem; // Import the InputSystem namespace to use the new input system

public class FlameScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    // These variables hold the Action refrences.
    InputAction moveAction;
        InputAction jumpAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        
        myRigidbody = GetComponent<Rigidbody2D>();
        // Find the references to move and jump actions
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        // read the move action, which is a 2D vector and jump which is a booleen value
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        //movement code
        if (jumpAction.IsPressed())
        {
            // jump code here
            myRigidbody.AddForce(Vector2.up);
        }

    }
}
