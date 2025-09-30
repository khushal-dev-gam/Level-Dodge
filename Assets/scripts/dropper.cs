using UnityEngine;

public class dropper : MonoBehaviour
{
    [SerializeField]float timetowait = 2f;
    MeshRenderer myMeshRenderer;
    Rigidbody boxrigidbody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
         boxrigidbody = GetComponent<Rigidbody>();

        boxrigidbody.useGravity = false;
        myMeshRenderer.enabled = false;
    }

    void Update()
    {
        if (Time.time > timetowait)
        {
           boxrigidbody.useGravity = true;
           myMeshRenderer.enabled = true;
        } 
    }
}
