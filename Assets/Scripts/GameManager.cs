using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool endGame = false;
    public static GameManager instance = null;

    public int deaths = 3;
    public bool isPlayerDestroyed = false;
    
    void Awake()
    {
       if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
         }
         else{
            Destroy(gameObject);
         }
    }
    void Update(){
        if (endGame){
            SceneManager.LoadScene("MainMenu");
            deaths=3;
            endGame=false;
      }        
    }
 
}
