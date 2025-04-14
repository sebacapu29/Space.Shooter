using System;
using System.Linq;
using TMPro;
using UnityEngine;

public class UIGame : MonoBehaviour
{
    private TextMeshProUGUI txtHealth;
    private TextMeshProUGUI txtGame;
    private TextMeshProUGUI txtGameChronometer;

    void Start()
    {
        var childrens = gameObject.GetComponentsInChildren<TextMeshProUGUI>();
        txtHealth = childrens.Where(x=> x.name == "TextHealth").First();
        txtGame =   childrens.Where(x=> x.name == "TextGame").First();
        txtGameChronometer = childrens.Where(x=> x.name == "TextTimer").First();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealthUI();
        UpdateChronometer();
        DisplayEndGame();
    }
    void DisplayEndGame(){
        if(GameManager.instance.endGame){
            txtGame.text ="Game Over";
        }
        else{
            txtGame.text = "";
        }  
    }
    void UpdateChronometer(){
        if(txtGameChronometer != null){
            txtGameChronometer.text = Math.Round(GameManager.instance.gameCounter,0).ToString() + "\"";
        }
    }
    void UpdateHealthUI(){

        if(txtHealth != null)
        {
            txtHealth.text = GameManager.instance.deaths.ToString();
        }
    }
}