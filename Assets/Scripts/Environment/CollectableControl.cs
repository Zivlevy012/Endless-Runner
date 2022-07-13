using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int CoinCount;
    public GameObject CoinCountDisplay;

    void Update()
    {
        CoinCountDisplay.GetComponent<Text>().text = "" + CoinCount;
    }

}

