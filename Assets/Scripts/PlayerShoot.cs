using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer laser;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if(Input.GetMouseButtonDown(0)){
            Instantiate(laser, transform.position + new Vector3(0,0.8f,0), transform.rotation);
            // disparo.Play();
            // bool choco = Physics.Raycast(transform.position, transform.forward);
            // if (choco)
            // {
            //     print("CHOCO");
            // }

            }
    }
}
