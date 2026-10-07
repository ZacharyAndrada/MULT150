using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{

    void Start()
    {
        for (int even = 22; even <= 100; even +=2)
        {
            Debug.Log(even);
        }
    }


    void Update()
    {
        
    }
}
