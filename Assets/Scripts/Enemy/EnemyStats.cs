using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public static EnemyStats instance;
    public int health=2;
    void Awake()
    {
        if(instance==null){
            instance = this;
        }
    }
}
