using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class player_alive : MonoBehaviour
{
    public Transform player_TR;
    public GameObject player_GO;

    public float cooldownTime = 3f;
    private float nextTime = 0f;

    void Update()
    {
        if(player_script.alive == false)
        {
            Debug.Log("player is dead");
            player_GO.SetActive(false);
            player_TR.position = transform.position;
            player_GO.SetActive(true);
            player_script.alive = true;
            /*
            if (Time.time >= nextTime)
            {
                player_TR.position = transform.position;
                player_GO.SetActive(true);
                player_script.alive = true;
                nextTime = Time.time + cooldownTime;
            }
            */
        }
    }
}
