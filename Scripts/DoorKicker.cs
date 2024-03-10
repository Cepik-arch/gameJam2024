using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKicker : MonoBehaviour
{
    public player_script player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (player.hasKey == true)
        {
            player.hasKey = false;
            this.gameObject.SetActive(false);
        }
    }
}
