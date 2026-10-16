using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        // Keyboard W,A,S,D
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if (hVal != 0)
            Debug.Log("Horizontal movement selected: " + hVal);
        if (vVal != 0)
            Debug.Log("Vertical movement selected: " + vVal);

        // Keyboard M & O
        if (Input.GetKey(KeyCode.M))
            Debug.Log("The 'M' key is pressed down");
        if (Input.GetKeyDown(KeyCode.O))
            Debug.Log("The 'O' key was pressed");

        // Mouse
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal != 0)
            Debug.Log("Mouse X movement selected: " + mxVal);
        if (myVal != 0)
            Debug.Log("Mouse Y movement selected: " + myVal);
    }
}
