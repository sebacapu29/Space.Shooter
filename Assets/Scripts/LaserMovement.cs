using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    [SerializeField]
    private int velocidadY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(0, velocidadY * Time.deltaTime, 0);
    }
}
