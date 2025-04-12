using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]   GameObject enemyPrefab;
    private float minSpawnTime = 1f;  
    private float maxSpawnTime = 3f;  
    private float randomTime;
    private float timeDificult = (float)LevelDificulties.Easy;
    private enum LevelDificulties{
        Hard = 20,
        Moderate = 30,
        Easy = 60
    }
    void Start()
    {
        randomTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void Update(){
        timeDificult-= Time.deltaTime;
        if(timeDificult < (float)LevelDificulties.Moderate){
            maxSpawnTime=1f;
        }
        if(timeDificult < (float)LevelDificulties.Hard){
            maxSpawnTime=0.2f;
        }
         randomTime -= Time.deltaTime;
            if( randomTime <= 0 ){
                randomTime = Random.Range(minSpawnTime, maxSpawnTime);;
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
                Instantiate(enemyPrefab, spawnPosition, transform.rotation);
        }
        else
        {
            Debug.LogWarning("Enemy prefab no asignado en el EnemyManager.");
        }
    }
}
