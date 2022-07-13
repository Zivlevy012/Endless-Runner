using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;
    [SerializeField] CharacterController CH;


    
    void OnTriggerEnter(Collider other)
    {
        //Plane.Length = Random.Range(Plane.Length);

         if (other.gameObject.CompareTag("Obstacle"))
         {
               SceneManager.LoadScene(0);
         }
    }

void Update()
    {
        CH.Move(Vector3.forward * Time.deltaTime * moveSpeed);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > Level_Boundry.leftSide)
            {
                CH.Move(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < Level_Boundry.rightSide)
            {
                CH.Move(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }
    }
}
