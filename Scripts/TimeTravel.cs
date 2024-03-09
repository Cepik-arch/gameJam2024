using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTravel : MonoBehaviour
{
    public WorldController worldController;
    public bool canTravel = false;
    public float cooldownTime = 1f;
    private float nextTravelTime = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canTravel && Time.time >= nextTravelTime)
        {
            worldController.ChangeScene();
            nextTravelTime = Time.time + cooldownTime;
        }
    }
}
