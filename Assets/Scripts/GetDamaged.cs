using UnityEngine;

public class GetDamaged : MonoBehaviour
{
    public GameObject explosionSprite;
    private SpriteRenderer originalSprite;
    private float respownTime = 2.5f;

    void Start()
    {
        originalSprite = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {        
      
        if (GameManager.instance.isPlayerDestroyed && gameObject.CompareTag("Player")) return;    
        if (GameManager.instance.isPlayerDestroyed && other.CompareTag("Player")) return;   

        if (!GameManager.instance.isPlayerDestroyed && gameObject.CompareTag("Player")){
            GameManager.instance.isPlayerDestroyed = true;
            AnimateExplode(); 
            if(GameManager.instance.deaths <= 0){
                EndGame();
            }
            else{
                GameManager.instance.deaths--;
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
        if (GameManager.instance.isPlayerDestroyed)
        {
            respownTime -= Time.deltaTime;
            if( respownTime <= 0 ){
                respownTime=6.0f;
                GameManager.instance.isPlayerDestroyed=false;
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
        originalSprite.enabled = false;
        Instantiate(explosionSprite, transform.position, transform.rotation);
    }
}
