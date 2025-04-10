using UnityEngine;

public class GetDamaged : MonoBehaviour
{
    public GameObject explosionSprite;
    private SpriteRenderer originalSprite;
    private bool isPlayerDestroyed = false;
    private float respownTime = 3.0f;
    private Collider2D playerCollider;
    void Start()
    {
        originalSprite = GetComponent<SpriteRenderer>();
         playerCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {        
      
        // if (isDestroyed) return;
        
        if (gameObject.CompareTag("Player")){
            isPlayerDestroyed=true;
            AnimateExplode(); 
            if(GameManager.instance.kills <= 0){
                EndGame();
            }
            else{
                GameManager.instance.kills--;
            }
        }
        else if (gameObject.name != "Player"){
            // isDestroyed = true;
            AnimateExplode();  
            Destroy(gameObject); 
        }
    }
    void Update()
    {
        if (isPlayerDestroyed)
        {
            respownTime -= Time.deltaTime;
            if( respownTime <= 0 ){
                respownTime=3.0f;
                isPlayerDestroyed=false;
                RespawnPlayer();
            }  
        }
     }
     void RespawnPlayer(){
        originalSprite.enabled = true;
     }
    void EndGame()
    {
        GameManager.instance.endGame = true;
    }
    private void AnimateExplode()
    {
        // isDestroyed=true;
        originalSprite.enabled = false;
        Instantiate(explosionSprite, transform.position, transform.rotation);
    }
}
