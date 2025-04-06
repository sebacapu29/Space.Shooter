using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]   GameObject enemyPrefab;
    [SerializeField]   GameObject enemyExplosion;
    private float minSpawnTime = 1f;  
    private float maxSpawnTime = 2f;  

    void Start()
    {
         StartCoroutine(nameof(SpawnEnemies));
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            SpawnEnemy();
        }
    }
    private void SpawnEnemy()
    {
        if (enemyPrefab != null)
        {
                Vector2 spawnPosition = new Vector2(
                    Random.Range(-1.8f, 1.8f),
                    Random.Range(5.5f, 6f)
                );
                var enemyObj = Instantiate(enemyPrefab, spawnPosition, transform.rotation);
        }
        else
        {
                Debug.LogWarning("Enemy prefab no asignado en el EnemyManager.");
        }
    }
}
