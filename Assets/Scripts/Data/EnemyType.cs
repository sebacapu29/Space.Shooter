using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

[CreateAssetMenu(fileName = "EnemyType", menuName = "Scriptable Objects/EnemyType")]
public class EnemyType : ScriptableObject
{
    [Header("Enemy Properties")]
    public GameObject enemyPrefab;
    public int enemyHealth = 0;
    public float enemySpeed = 0;
    public int pointGiven = 20;

    [Header("Bullet Properties")]
    public GameObject enemyBullet;
    public int bulletDamage = 1;
    public float bulletSpeed = 0f;
    public float shootCoolDown = 0f;
 
}
