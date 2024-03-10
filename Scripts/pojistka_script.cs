using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pojistka_script : MonoBehaviour
{
    public Collider2D player_CO;

    void OnTriggerEnter2D(Collider2D player_CO)
    {
        Debug.Log("Sebral jsi pojistku.");
        //player_script.pojistka = true;
        Destroy(gameObject);
    }




}
