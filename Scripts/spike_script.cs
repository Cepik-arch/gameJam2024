using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike_script : MonoBehaviour
{
    public Collider2D player_C0;


    void OnTriggerEnter2D(Collider2D player_C0)
    {
        //Debug.Log("Šlapnul jsi na spiky.");
        player_script.alive = false;

    }
}
