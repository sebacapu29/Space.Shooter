using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;
    [SerializeField] int health = 3;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void SetHealth(int valueHealth){
        if(valueHealth >=0 ){
            health = valueHealth;
        }
    }
    public int GetHealth(){
        return health;
    }
}
