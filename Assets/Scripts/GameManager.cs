using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool endGame = false;
    public static GameManager instance = null;
    void Awake()
    {
        if(instance == null)
        {
            instance=this;
        }
    }
    void Start()
    {
        
    }
    void Update(){
        if (endGame){
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
}
