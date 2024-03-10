using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class spike_script : MonoBehaviour
{
    public GameObject player;
    public GameObject checkpoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            player.transform.position = checkpoint.transform.position;
            player.SetActive(true);
        }
    }

}
