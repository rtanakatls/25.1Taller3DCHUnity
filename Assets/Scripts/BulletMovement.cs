using UnityEngine;

public class BulletMovement : CharacterMovement
{
    [SerializeField] protected Vector3 direction;

    public void SetDirection(Vector3 direction)
    {
        this.direction = direction;
    }

    protected override void Move()
    {
        rb.linearVelocity = direction.normalized * speed;
    }
}

