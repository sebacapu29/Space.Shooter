using UnityEngine;

public class GetDamaged : MonoBehaviour
{
    public GameObject explosionSprite;
    private SpriteRenderer originalSprite;

    private bool isDestroyed = false;
    private float targetTime = 1.0f;
    void Start()
    {
        originalSprite = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {        
        if (isDestroyed) return;

        if(other.CompareTag("DestroyObjects"))
        {
            isDestroyed = true;
        }
        if (other.CompareTag("Player") || other.CompareTag("Enemy") ) {
            Explode();  
            isDestroyed=true;
        }
        if(other.CompareTag("LaserBlue")){
            Explode();
            isDestroyed=true;
        }
    }

    void EndGame(){
        if (GameManager.instance != null)
        {
            GameManager.instance.endGame = true;
        }
        else
        {
            Debug.LogWarning("GameManager no está disponible.");
        }
    }
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f && isDestroyed)
        {
            EndGame();
            Destroy(gameObject);
            isDestroyed=false;
        }
    }
    private void Explode()
    {
        originalSprite.enabled = false;
        Instantiate(explosionSprite, transform.position, transform.rotation);
    }
}
