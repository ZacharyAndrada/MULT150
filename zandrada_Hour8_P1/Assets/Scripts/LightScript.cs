using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light lightbulb;

    void Start()
    {
        lightbulb = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            lightbulb.enabled = !lightbulb.enabled;
        }
    }
}
