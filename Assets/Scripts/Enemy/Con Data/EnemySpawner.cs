using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;

public class EnemySpawner : MonoBehaviour
{
   
   [SerializeField] SplineContainer _spline;
   [SerializeField] EnemyType _enemyType;
   [SerializeField] int _maxEnemies = 10;
   [SerializeField] float _spawnTime = 2f;

   int _enemyCount;
   float _spawningTimer;
   float3 _spawnPoint;

    void Start()
    {
        _spawnPoint = _spline.EvaluatePosition(0f);
    }

    // Update is called once per frame
    void Update()
    {
        _spawningTimer += Time.deltaTime;

        if(_spawningTimer >= _spawnTime && _enemyCount <= _maxEnemies){
            _spawningTimer = 0f;
            _enemyCount ++;
            InstantiateEnemies();
        }
    }

    private void InstantiateEnemies()
    {
        GameObject enemy = Instantiate(_enemyType.enemyPrefab, _spawnPoint, Quaternion.identity);
        SplineAnimate spAnimateEnemy = enemy.GetComponent<SplineAnimate>();
        spAnimateEnemy.Container = _spline;
        spAnimateEnemy.AnimationMethod = SplineAnimate.Method.Speed;
        spAnimateEnemy.ObjectUpAxis = SplineComponent.AlignAxis.YAxis;
        spAnimateEnemy.ObjectForwardAxis = SplineComponent.AlignAxis.ZAxis;
        spAnimateEnemy.MaxSpeed = _enemyType.enemySpeed;
        spAnimateEnemy.PlayOnAwake = true;
    }
}
