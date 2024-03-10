using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClockCollect : MonoBehaviour
{
    public TimeTravel timeTravel;
    public AudioSource pickUpLine;

    public GameObject dialog;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            pickUpLine.Play();
            dialog.SetActive(true);
            timeTravel.canTravel = true;
            this.gameObject.SetActive(false);    
        }
    }
}
