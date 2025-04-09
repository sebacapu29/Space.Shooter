using UnityEditor.SearchService;
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
        btnPlay.onClick.AddListener(()=> SceneManager.LoadScene("SampleScene"));
    }
}
