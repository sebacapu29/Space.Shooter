using TMPro;
using UnityEditor.SearchService;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.UI.Button;

public class UIManager : MonoBehaviour
{
    public Button btnPlay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string messageMenu= "Play";
        if(GameManager.instance!= null){
            messageMenu = GameManager.instance.endGame ? "Retry" : "Play";
        }
        var textMesh = btnPlay.GetComponentInChildren<TextMeshProUGUI>();
        if(textMesh!=null){
            btnPlay.GetComponentInChildren<TextMeshProUGUI>().text = messageMenu;
        }
        else{
            Debug.Log("fail");
        }
        btnPlay.onClick.AddListener(()=> SceneManager.LoadScene("SampleScene"));
    }
}
