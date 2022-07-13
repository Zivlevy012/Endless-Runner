using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGround : MonoBehaviour
{
    [SerializeField] GameObject[] Ground;
    

    void OnTriggerEnter(Collider other)
    {
        //Ground.Length = Random.Range(Ground.Length);

        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 Ref = new Vector3(0, -3.85f, 76);
            Instantiate(Ground[Random.Range(0, Ground.Length)], transform.position + Ref, Quaternion.Euler(0,0,0));


        }
    }
    
}
