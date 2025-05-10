using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] protected float speed;
    protected Rigidbody rb;

    private void Awake()
    {
        Init();
    }

    protected virtual void Init()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    protected virtual void Move()
    {

    }
}
