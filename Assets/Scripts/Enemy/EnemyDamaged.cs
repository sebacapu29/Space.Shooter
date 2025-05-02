using UnityEngine;

public class EnemyDamaged : MonoBehaviour
{
    public GameObject explosionSprite;
    private SpriteRenderer originalSprite;

    void Start()
    {
        originalSprite = GetComponent<SpriteRenderer>();
    }

     private void OnTriggerEnter2D(Collider2D other)
    {        
      
        if (other.tag == "LaserBlue" || other.tag == "Player"){
            var enemy = gameObject.GetComponent<EnemyStats>();
            if(enemy!=null && enemy.health > 0){
                enemy.health--;
                if(enemy.health <=0){
                    AnimateExplode();  
                    Destroy(gameObject); 
                }
            }
        }
    }
     private void AnimateExplode()
    {
        originalSprite.enabled = false;
        Instantiate(explosionSprite, transform.position, transform.rotation);
    }
}
