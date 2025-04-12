using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool endGame = false;
    public static GameManager instance = null;

    public int deaths = 3;
    public bool isPlayerDestroyed = false;
    private float gameOverSecondsDisplayed = 3f;
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
            gameOverSecondsDisplayed -= Time.deltaTime;
            if( gameOverSecondsDisplayed <= 0 ){
                gameOverSecondsDisplayed = 3.0f;
                SceneManager.LoadScene("MainMenu");
                deaths=3;
                endGame=false;    
            }  
      }        
    }
 
}
