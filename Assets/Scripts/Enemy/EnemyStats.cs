using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public static EnemyStats instance;
    public int health;
    void Awake()
    {
        if(instance==null){
            instance = this;
        }
    }
}
