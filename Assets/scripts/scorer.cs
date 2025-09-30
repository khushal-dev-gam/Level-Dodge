using UnityEngine;

public class scorer : MonoBehaviour
{
    int hits;  
    private void OnCollisionEnter(Collision other) {

        if (other.gameObject.tag != "Hit")
        {
         hits++;
        Debug.Log("dogesh bhai itni baar takra chuke hai: "+hits);

      }
       
    }
}
