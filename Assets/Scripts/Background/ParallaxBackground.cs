using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] Transform[] _backgrounds;
    [SerializeField] float[] _parallaxSpeed;
    [SerializeField] float _smoth =10f;
    Vector3 _backgroundNextPosition;

    void Update()
    {
        for (int i = 0; i < _backgrounds.Length; i++)
        {
            float bPos = _backgrounds[i].position.y;
            bPos -= _parallaxSpeed[i] * Time.deltaTime;
            _backgroundNextPosition = new Vector3(_backgrounds[i].position.x, bPos, _backgrounds[i].position.z) ; 
            _backgrounds[i].position = Vector3.Lerp(_backgrounds[i].position, _backgroundNextPosition,_smoth * Time.deltaTime);
        }
    }
}
