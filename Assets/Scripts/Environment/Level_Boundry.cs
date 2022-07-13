using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Boundry : MonoBehaviour
{
    public static float leftSide = -6.5f;
    public static float rightSide = 8.5f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;

        
    }
}
