using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(h, 0, v).normalized;
        Vector3 velocity = direction*speed + new Vector3(0, rb.linearVelocity.y, 0);

        rb.linearVelocity = velocity;
    }
}
