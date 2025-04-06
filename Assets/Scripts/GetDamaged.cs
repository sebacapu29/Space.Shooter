using UnityEngine;

public class GetDamaged : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"{gameObject.name} entró en trigger con {other.gameObject.name}");
        Destroy(gameObject);
    }
}
