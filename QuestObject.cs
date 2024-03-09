using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(Variables.questItem == null)
        {
            Variables.questItem = gameObject;
            other.GetComponent<player_script>().hasQuestItem = true;
            Destroy(gameObject);
        }
    }
}
