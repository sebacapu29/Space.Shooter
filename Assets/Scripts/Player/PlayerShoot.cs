using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer laser;
    void Update()
    {
      if(GameManager.instance.isPlayerDestroyed) return;

        if(Input.GetMouseButtonDown(0)){
            Instantiate(laser, transform.position + new Vector3(0,0.8f,0), transform.rotation);
        }
    }
}
