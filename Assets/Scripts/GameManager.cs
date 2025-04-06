using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool endGame = false;
    public static GameManager instance = null;
    [RuntimeInitializeOnLoadMethod]
static void OnRuntimeMethodLoad()
{
    if (instance == null)
    {
        GameObject gm = new GameObject("GameManager");
        gm.AddComponent<GameManager>();
    }
}
    void Awake()
    {
        instance = this;
        // if(instance == null){
        //     instance = this;
        //     DontDestroyOnLoad(gameObject);
        //  }
        //  else{
        //     Destroy(gameObject);
        //  }
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
