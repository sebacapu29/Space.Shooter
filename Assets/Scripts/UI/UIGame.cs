using System.Linq;
using TMPro;
using UnityEngine;

public class UIGame : MonoBehaviour
{
    private TextMeshProUGUI txtHealth;
    private TextMeshProUGUI txtGame;

    void Start()
    {
        var childrens = gameObject.GetComponentsInChildren<TextMeshProUGUI>();
        txtHealth = childrens.Where(x=> x.name == "TextHealth").First();
        txtGame =   childrens.Where(x=> x.name == "TextGame").First();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealthUI();
        if(GameManager.instance.endGame){
            txtGame.text ="Game Over";
        }
        else{
            txtGame.text = "";
        }  
    }
    void UpdateHealthUI(){

        if(txtHealth != null)
        {
            txtHealth.text = GameManager.instance.deaths.ToString();
        }
    }
}
