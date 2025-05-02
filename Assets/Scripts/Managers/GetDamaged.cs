using UnityEngine;

public class GetDamaged : MonoBehaviour
{
    public GameObject explosionSprite;
    private SpriteRenderer originalSprite;
    // private float respownTime = 2f;

    void Start()
    {
        originalSprite = GetComponent<SpriteRenderer>();
    }
    protected virtual void AnimateExplode()
    {
        originalSprite.enabled = false;
        Instantiate(explosionSprite, transform.position, transform.rotation);
    }
}
