using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // February Standard Year
    void Start()
    {
        int birthday = 27;

        for (int days = 1; days <= 28; days++)
        {
            if (days == birthday)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(days);
            }
        }
    }


    void Update()
    {
        
    }
}
