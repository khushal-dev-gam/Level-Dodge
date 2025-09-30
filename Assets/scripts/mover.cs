using UnityEngine;

public class mover : MonoBehaviour
{
  [SerializeField] float movespeed;
  void Start()
  {
    movespeed = 15f;
    Printinstruction();
  }
  void Update()
  {
    PlayerMovement();
  }
  void Printinstruction()
  {
    Debug.Log("wELCOME TO THE DOGESH GAME");
    Debug.Log("MOVE LEFT AND RIGHT FROM A&D");
    Debug.Log("MOVE FORWARD AND BACKWARD FROM W&S");
  }
  void PlayerMovement()
  {

  float xv = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
    float yv = 0f;
    float zv = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
    transform.Translate(xv, yv, zv);
   }
}

