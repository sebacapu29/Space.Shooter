using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] float speed = 0;
    [SerializeField] SpriteRenderer playerSprite;
    [SerializeField] GameObject player;
    
    private Vector3 spriteBounds;
    private Vector3 screenBounds;
    private Vector3 playerPos;

    void Start()
    {
        playerSprite = player.GetComponent<SpriteRenderer>();
        spriteBounds = playerSprite.bounds.extents / 2;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

    }

    void Update()
    {
        playerPos.x = Input.GetAxis("Horizontal");
        playerPos.y = Input.GetAxis("Vertical");

        playerPos = playerPos.normalized; 

        StayOnScreen();
    }

    void StayOnScreen(){
        var safePosition = transform.position;

        transform.position += new Vector3(playerPos.x, playerPos.y ,0) * speed * Time.deltaTime;

        if(transform.position.x < (- screenBounds.x + spriteBounds.x) || 
                                    transform.position.x > (screenBounds.x - spriteBounds.x)){
           transform.position = new Vector3(safePosition.x, safePosition.y,0);
        }
           if(transform.position.y < (- screenBounds.y + spriteBounds.y) || 
                                    transform.position.y > (screenBounds.y - spriteBounds.y)){
           transform.position = new Vector3(safePosition.x, safePosition.y, 0);
        }
    }
}
