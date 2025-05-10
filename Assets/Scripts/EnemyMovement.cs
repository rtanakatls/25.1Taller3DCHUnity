using UnityEngine;

public class EnemyMovement : CharacterMovement
{
    protected override void Move()
    {
        rb.linearVelocity = Vector3.right * speed;
    }
}
