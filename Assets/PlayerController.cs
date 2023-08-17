using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float Acceleration = 200;
    [SerializeField] public float MaxVelocity = 5;
    [SerializeField] public Rigidbody2D Head;

    void Update()
    {
        // get player input, and convert to a 2D angle
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);

        // move player by applying thrust, then cap velocity
        Head.AddForce(inputVector * Acceleration);
        Head.velocity = Vector2.ClampMagnitude(Head.velocity, MaxVelocity);
    }
}
