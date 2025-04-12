using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 15f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.MovePosition(rb.position + Vector2.up * speed * Time.fixedDeltaTime);
    }
}
