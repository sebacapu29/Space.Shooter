using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public GameObject explosionSprite;
    private SpriteRenderer originalSprite;
    private float respownTime = 2f;

    void Start()
    {
        originalSprite = GetComponent<SpriteRenderer>();
    }

 private void OnTriggerEnter2D(Collider2D other)
    {        
      
        if (GameManager.instance.isPlayerDestroyed) return;      

        if (!GameManager.instance.isPlayerDestroyed && other.CompareTag("Enemy")){
            GameManager.instance.isPlayerDestroyed = true;
            AnimateExplode(); 
            if(GameManager.instance.deaths <= 0){
                EndGame();
            }
            else{
                GameManager.instance.deaths--;
            }
        }
    }
    private void AnimateExplode()
    {
        originalSprite.enabled = false;
        Instantiate(explosionSprite, transform.position, transform.rotation);
    }
    void EndGame()
    {
        GameManager.instance.endGame = true;
    }
}
