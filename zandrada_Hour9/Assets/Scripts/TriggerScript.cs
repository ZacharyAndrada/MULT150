using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has enter the " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in the " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left the " + gameObject.name);
    }
}
