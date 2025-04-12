using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button btnPlay;
    public TextMeshProUGUI txtButtonPlay;
    void Awake(){
        btnPlay = gameObject.GetComponentInChildren<Button>();
        txtButtonPlay = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }
    void Start()
    {
        string messageMenu= "Play";
        if(GameManager.instance!= null){
            messageMenu = GameManager.instance.endGame ? "Retry" : "Play";
        }
        if(txtButtonPlay!=null){
            txtButtonPlay.text = messageMenu;
        }
        else{
            Debug.Log("fail");
        }

        btnPlay.onClick.AddListener(()=> SceneManager.LoadScene("GameScene"));
    }
    
}
