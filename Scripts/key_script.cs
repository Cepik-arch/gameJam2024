using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_script : MonoBehaviour
{
    public Collider2D player_CO;

    void OnTriggerEnter2D(Collider2D player_CO)
    {
        Debug.Log("Sebral jsi klíè.");
        //player_script.key = true;
        Destroy(gameObject);
    }
}
