using UnityEngine;

public class DestroyLaser : GetDamaged
{
  private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
        {
            AnimateExplode();
            Destroy(gameObject);
        }
    }

    protected override void AnimateExplode()
    {
        base.AnimateExplode();
    }
}
