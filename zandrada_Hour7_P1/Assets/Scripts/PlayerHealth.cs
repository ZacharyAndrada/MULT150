using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    void Start()
    {
        float health = 1004;
        float poisonDamage = 125.5f;
        Debug.Log(health);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);

        string saying = ("Player has been unalived!");
        Debug.Log(saying);
    }


    void Update()
    {
        
    }
}
