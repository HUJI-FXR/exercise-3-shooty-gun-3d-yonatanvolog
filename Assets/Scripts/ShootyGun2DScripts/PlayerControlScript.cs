using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    [SerializeField] private MovementScript movementScript;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 1f;

    private void Update()
    {
        // Left and Right movement
        if (Input.GetKey(KeyCode.A))
        {
            movementScript.SetHorizontalVelocity(-moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movementScript.SetHorizontalVelocity(moveSpeed);
        }
        else
        {
            movementScript.SetHorizontalVelocity(0);
        }

        // Jump
        if (Input.GetKey(KeyCode.W) && movementScript.IsGrounded())
        {
            movementScript.Jump(jumpForce);
        }
    }
}
