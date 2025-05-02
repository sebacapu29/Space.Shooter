using UnityEngine;

public class EnemyDamaged : GetDamaged
{
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
    protected override void AnimateExplode()
    {
        base.AnimateExplode();
    }
}
