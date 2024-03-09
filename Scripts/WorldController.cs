using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldController : MonoBehaviour
{
    public GameObject worldDestroyed;

    public GameObject worldNormal;

    void Start()
    {
        Debug.Log("Realm: " + Variables.realm);
    }

    public void ChangeScene()
    {
        Debug.Log("Changing scene");
        if (Variables.realm == 0)
        {
            Variables.realm = 1;
            worldDestroyed.SetActive(false);
            worldNormal.SetActive(true);
        }
        else if (Variables.realm == 1)
        {
            Variables.realm = 0;
            worldDestroyed.SetActive(true);
            worldNormal.SetActive(false);
        }
    }
}
