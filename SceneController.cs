using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Realm: " + Variables.realm);
    }

    public void ChangeScene()
    {
        Debug.Log("Changing scene");
        if(Variables.realm == 0)
        {
            Variables.realm = 1;
            SceneManager.LoadScene("budoucnost", LoadSceneMode.Single);
        }
        else if(Variables.realm == 1)
        {
            Variables.realm = 0;
            SceneManager.LoadScene("minulost", LoadSceneMode.Single);
        }
    }
}
