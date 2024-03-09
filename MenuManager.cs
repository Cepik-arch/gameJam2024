using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menuInterface;

    public GameObject player;
    public void StartGame()
    {
        menuInterface.SetActive(false);
        player.SetActive(true);
    }

}
