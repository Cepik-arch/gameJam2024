    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Child : MonoBehaviour
{
    public TextMeshProUGUI text;
    public player_script player;
    public List<string> childQuest = new List<string>() { "Prosim dones medu", "Ti povim tajemstvi","Uz mas medu?", "Diky, ze jsi mi pomohl"};
    public int textCounter = 0;

    void Start()
    {
        text.enabled = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Child: " + text);
        text.enabled = true; 
    }

    public void OnClickChangeText()
    {
        /*
        if (textCounter == -1)
        {
            return;
        }
        text.text = childQuest[textCounter];
        textCounter++;
        Debug.Log(textCounter);
        if (textCounter == 2)
        {
            Variables.currentQuest = "Dones medu borcovi";
            player.UpdateQuest();
        }
        if (textCounter == 3)
        {
            textCounter--;
        }
        if (player.hasQuestItem == true)
        {
            Variables.currentQuest = "";
            text.text = "Dyk kod je 1994";
            player.hasQuestItem = false;
            player.UpdateQuest();
            textCounter = -1;
        }
        */
    }
}
