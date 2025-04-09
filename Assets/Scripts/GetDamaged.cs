using UnityEngine;

public class GetDamaged : MonoBehaviour
{
    public GameObject explosionSprite;
    private SpriteRenderer originalSprite;
    private bool isDestroyed = false;
    private float targetTime = 1.0f;
    private bool isVulnerable = false;
    void Start()
    {
        originalSprite = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {        
      
        if (!other.CompareTag("Player") && isDestroyed) return;

        if(other.CompareTag("DestroyObjects"))
        {
            isDestroyed = true;
        }
        if (other.CompareTag("Player") && !isVulnerable) {
            Debug.Log("Player Health  "+ PlayerStats.instance.GetHealth());
            if(PlayerStats.instance.GetHealth() == 0 ){
                // AnimateExplode(other.tag);          
            }
            else{
                // isHurted = true;
                isVulnerable = true;
                int newHealth = PlayerStats.instance.GetHealth() - 1;
                PlayerStats.instance.SetHealth(newHealth);
            }
        }
        else if(other.CompareTag("LaserBlue")){
            AnimateExplode();
        }
        else if(other.CompareTag("Enemy")){
            AnimateExplode();
        }
    }
    void Update()
    {
        if (isDestroyed && !gameObject.tag.Equals("Player"))
        {

            Destroy(gameObject);
        }
        else if (isDestroyed && gameObject.tag.Equals("Player")){
            EndGame();
        }
        if(isVulnerable){
            targetTime -= Time.deltaTime;
            if( targetTime <= 0 ){
                isVulnerable = false;
            }
        }
     }
    void EndGame()
    {
        GameManager.instance.endGame = true;
    }
    private void AnimateExplode()
    {
        isDestroyed=true;
        originalSprite.enabled = false;
        Instantiate(explosionSprite, transform.position, transform.rotation);
    }
}
