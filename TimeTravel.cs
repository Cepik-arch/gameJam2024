using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTravel : MonoBehaviour
{
    public WorldController worldController;
    void Update()
    {
        // Check if 'E' key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Call the public method from the other script
            worldController.ChangeScene();
        }
    }
}
