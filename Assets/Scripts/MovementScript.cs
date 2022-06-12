using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float movementSpeed = 5;
    public Rigidbody2D rb;
    public Vector2 movement;


    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
    }


    private void FixedUpdate()
    {
        if (movement != Vector2.zero)
        {
            rb.velocity = movement * movementSpeed;
        }
        else rb.velocity = Vector2.zero;

    }

}
