using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] Rigidbody RB;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical")> 0)
        {
            RB.AddForce(transform.forward * 5);
        }
    }
}
