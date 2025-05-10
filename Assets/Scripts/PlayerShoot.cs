using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    private PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }


    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
            obj.GetComponent<BulletMovement>().SetDirection(playerMovement.LookAtDirection);
        }
    }
}
