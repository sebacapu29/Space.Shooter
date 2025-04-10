using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool endGame = false;
    public static GameManager instance = null;
    public TextMeshProUGUI healthUI;
    public int kills =3;

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
        }
        UpdateHealthUI();
    }
    void UpdateHealthUI(){
        healthUI.text = kills.ToString();
    }
    void RespawnPlayer(){

    }
}
