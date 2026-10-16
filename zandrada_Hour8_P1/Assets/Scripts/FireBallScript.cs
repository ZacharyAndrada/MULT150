using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{

    void Start()
    {
        // First
        int x = TakeDamageFromFireball();
        Debug.Log("Player health: " + x);

        // Second
        int y = TakeDamageFromFireball(25);
        Debug.Log("Player health: " + y);

        // Third
        int z = TakeDamageFromFireball(30, 50);
        Debug.Log("Player health: " + z);
    }


    void Update()
    {
        
    }

    // First method
    int TakeDamageFromFireball()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }

    // Second method
    int TakeDamageFromFireball(int damage)
    {
        int playerHealth = 100;
        return playerHealth - damage;
    }

    // Third method
    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }
}
