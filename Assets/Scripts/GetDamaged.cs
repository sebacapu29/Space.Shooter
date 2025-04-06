using System;
using System.Collections;
using UnityEngine;

public class GetDamaged : MonoBehaviour
{
    public Sprite explosionSprite;
    private Sprite originalSprite;

    private SpriteRenderer spriteRenderer;
    private Collider2D col;
    private bool isDestroyed = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
        originalSprite = spriteRenderer.sprite;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isDestroyed) return;

        if (other.CompareTag("Player") || other.CompareTag("Enemy") ) {  
            StartCoroutine(ExplodeAndDestroy(0.1f));
        }
        if(other.CompareTag("LaserBlue")){
            StartCoroutine(ExplodeAndDestroy(0.8f));
        }
        if(other.CompareTag("Player")){
            GameManager.instance.endGame = true;
        }
    }

    private IEnumerator ExplodeAndDestroy(float fadeDuration)
    {
        isDestroyed = true;

        if (explosionSprite != null)
        {
            spriteRenderer.sprite = explosionSprite;
        }

        if (col != null)
            col.enabled = false;

        var rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = Vector2.zero;
            rb.useFullKinematicContacts = true;
        }
        float timer = 0f;

        Color originalColor = spriteRenderer.color;

        while (timer < fadeDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration);
            spriteRenderer.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            timer += Time.deltaTime;
            yield return null;
        }

        // Asegurarse de que termine completamente transparente
        spriteRenderer.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
        // yield return new WaitForSeconds(0.8f);

        Destroy(gameObject);
    }
}
