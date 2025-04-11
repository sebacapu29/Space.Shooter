using TMPro;
using UnityEngine;

public class UIGame : MonoBehaviour
{
    private TextMeshProUGUI txtHealth;
    void Start()
    {
        txtHealth = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealthUI();
    }
    void UpdateHealthUI(){
        if(txtHealth != null)
        {
            txtHealth.text = GameManager.instance.deaths.ToString();
        }
    }
}
