using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItemCollect : MonoBehaviour
{
    public player_script player;
    public AudioSource pickUpLine;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {   
            pickUpLine.Play();
            player.setQuestItem(true);
            this.gameObject.SetActive(false);
        }
    }

}
