using UnityEngine;

public class PlayerDamage : GetDamaged
{
private float respownTime = 2f;

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
    protected override void AnimateExplode()
    {
        base.AnimateExplode();
    }
    void EndGame()
    {
        GameManager.instance.endGame = true;
    }
}
