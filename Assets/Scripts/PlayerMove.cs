using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField]
    private float speed = 0;
    [SerializeField]
    private SpriteRenderer playerSprite;
    [SerializeField]
    private PlayerMove player;
    
    private Vector3 spriteBounds;
    private Vector3 screenBounds;
    private Vector3 playerPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerSprite = player.GetComponent<SpriteRenderer>();
        spriteBounds = playerSprite.bounds.extents / 2;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

    }

    // Update is called once per frame
    void Update()
    {
        playerPos.x = Input.GetAxis("Horizontal");
        playerPos.y = Input.GetAxis("Vertical");

        playerPos = playerPos.normalized;   

        transform.Translate(playerPos.x * speed * Time.deltaTime, playerPos.y * speed * Time.deltaTime,0);
    }
}
