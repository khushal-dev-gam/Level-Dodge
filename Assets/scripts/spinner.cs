using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField]float xr = 0f;
   [SerializeField]float yr = 1f;
    [SerializeField]float zr = 0f;
    void Start()
    {
        
    }

    
    void Update()
    {
      transform.Rotate(xr,yr,zr);
    }
}
