using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] float bulletspeed = 1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

 void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
        
    }


    void Update()
    {
        moveToPlayer();
        DestroyWhenReached();
    }

    void moveToPlayer()
    {
    transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * bulletspeed);
   }
   
   
     void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
            
        }
     }

}
