using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
 [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform leftSpawn;
    [SerializeField] private Transform rightSpawn;
    [SerializeField] private float shootCooldown = 0.1f;

    private float cooldownTimer;
    private bool shootLeft = true;

    void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (Input.GetMouseButton(0) && cooldownTimer >= shootCooldown)
        {
            Shoot();
            cooldownTimer = 0f;
        }
    }

    void Shoot()
    {
        Transform spawnPoint = shootLeft ? leftSpawn : rightSpawn;
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.up * 10f;

        shootLeft = !shootLeft;
    }
}
