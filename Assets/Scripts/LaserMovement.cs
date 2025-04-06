using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    [SerializeField]
    private int velocidadY;
    private Rigidbody2D rb;
    public float speed = 15f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.up * speed * Time.fixedDeltaTime);
    }
}
