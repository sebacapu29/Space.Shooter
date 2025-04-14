using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public bool endGame = false;
    public float gameCounter = 0f;
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
        if(!endGame)
        {
            gameCounter += Time.deltaTime;
        }         
        if (endGame){
            gameOverSecondsDisplayed -= Time.deltaTime;
            if( gameOverSecondsDisplayed <= 0 ){
                gameOverSecondsDisplayed = 3.0f;
                deaths=3;
                endGame=false; 
                gameCounter = 0f;   
                SceneManager.LoadScene("MainMenu");
            }  
      }        
    }
 
}
