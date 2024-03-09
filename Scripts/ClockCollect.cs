using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClockCollect : MonoBehaviour
{
    public TimeTravel timeTravel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            timeTravel.canTravel = true;
            this.gameObject.SetActive(false);    
        }
    }
}
