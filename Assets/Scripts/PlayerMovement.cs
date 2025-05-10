using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    protected Vector3 lookAtDirection;

    public Vector3 LookAtDirection {  get { return lookAtDirection; } }

    protected override void Init()
    {
        base.Init();
        lookAtDirection = Vector3.forward;
    }

    protected override void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(h, 0, v).normalized;
        Vector3 velocity = direction*speed + new Vector3(0, rb.linearVelocity.y, 0);

        rb.linearVelocity = velocity;

        if(direction.magnitude > 0 )
        {
            transform.forward = direction;
            lookAtDirection = direction;
        }

    }
}
