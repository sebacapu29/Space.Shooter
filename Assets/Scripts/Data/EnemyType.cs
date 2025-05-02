using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

[CreateAssetMenu(fileName = "EnemyType", menuName = "Scriptable Objects/EnemyType")]
public class EnemyType : ScriptableObject
{
    [Header("Enemigo")]
    public Spline spline;
    public GameObject enemyPrefab;
    public int healthEnemy;
    public int spawnEnemy;
    public List<Spline> splines;
    public int randomIndex;
    
 
}
