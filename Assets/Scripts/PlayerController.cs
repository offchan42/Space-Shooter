using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        var velocity = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = velocity;
    }
}