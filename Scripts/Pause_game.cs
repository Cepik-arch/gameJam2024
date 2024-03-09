using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_game : MonoBehaviour
{
    public Transform Camera_TR;

    public GameObject paused_GO;
    public GameObject MusicOn;
    public GameObject MusicOff;
    public GameObject SoundOn;
    public GameObject SoundOff;

    public GameObject paused_GO_N;
    public GameObject MusicOn_N;
    public GameObject MusicOff_N;
    public GameObject SoundOn_N;
    public GameObject SoundOff_N;

    public bool paused = false;

    //audio
    AudioSource[] audioSources = FindObjectsOfType<AudioSource>();
    public string SoundTag = "Sounds";
    public string MusicTag = "Music";

    void Start()
    {
        paused_GO.SetActive(false);
        paused_GO_N.SetActive(false);
        SoundOff.SetActive(false);
        MusicOff.SetActive(false);
    }

    void Update()
    {
        //transform.position = Camera_TR.transform.position;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Variables.realm == 0)
            {
                Debug.Log("Paused");
                Time.timeScale = 0;
                paused = true;
                paused_GO.SetActive(true);
            }
            else if (Variables.realm == 1)
            {
                Debug.Log("Paused");
                Time.timeScale = 0;
                paused = true;
                paused_GO_N.SetActive(true);
            }
        }
        // Získání pozice kurzoru ve 2D prostoru
        Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Vytvoøení paprsku od kamery do pozice kurzoru
        RaycastHit2D hit = Physics2D.Raycast(cursorPosition, Vector2.zero);

        ///////////////// pause menu pro znièený svìt

        // pokraèování ve høe
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "Play_D")
        {
            if (Variables.realm == 0)
            {
                Debug.Log("Hra byla odpauznuta");
                paused_GO.SetActive(false);
                paused = false;
                Time.timeScale = 1;
            }
            else if (Variables.realm == 1)
            {
                Debug.Log("Hra byla odpauznuta");
                paused_GO_N.SetActive(false);
                paused = false;
                Time.timeScale = 1;
            }
        }
        //ukonèení hry
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "Exit_D")
        {
            Debug.Log("Hra byla ukonèena.");
            //Application.Quit();
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "SoundOn_D")
        {
            Debug.Log("zvuk");
            SoundOn.SetActive(false);
            SoundOff.SetActive(true);
            foreach (AudioSource audioSource in audioSources)
            {
                if (audioSource.CompareTag(SoundTag))
                {
                    audioSource.enabled = false; // Vypneme Audio Source s odpovídajícím tagem
                }
            }
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "SoundOff_D")
        {
            Debug.Log("zvukoff");
            SoundOn.SetActive(true);
            SoundOff.SetActive(false);
            foreach (AudioSource audioSource in audioSources)
            {
                if (audioSource.CompareTag(SoundTag))
                {
                    audioSource.enabled = true; // Zapneme Audio Source s odpovídajícím tagem
                }
            }
        }

        if (Input.GetMouseButtonDown(0) && hit.collider.name == "MusicOn_D")
        {
            Debug.Log("hudba");
            MusicOn.SetActive(false);
            MusicOff.SetActive(true);
            foreach (AudioSource audioSource in audioSources)
            {
                if (audioSource.CompareTag(MusicTag))
                {
                    audioSource.enabled = false; // Vypneme Audio Source s odpovídajícím tagem
                }
            }
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "MusicOff_D")
        {
            Debug.Log("hudbaoff");
            MusicOn.SetActive(true);
            MusicOff.SetActive(false);
            foreach (AudioSource audioSource in audioSources)
            {
                if (audioSource.CompareTag(MusicTag))
                {
                    audioSource.enabled = true; // Zapneme Audio Source s odpovídajícím tagem
                }
            }
        }

        //////////////// pause menu pro dobrý svìt

        // pokraèování ve høe
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "Play_N")
        {
            if (Variables.realm == 0)
            {
                Debug.Log("Hra byla odpauznuta");
                paused_GO.SetActive(false);
                paused = false;
                Time.timeScale = 1;
            }
            else if (Variables.realm == 1)
            {
                Debug.Log("Hra byla odpauznuta");
                paused_GO_N.SetActive(false);
                paused = false;
                Time.timeScale = 1;
            }
        }
        //ukonèení hry
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "Exit_N")
        {
            Debug.Log("Hra byla ukonèena.");
            //Application.Quit();
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "SoundOn_N")
        {
            Debug.Log("zvuk");
            SoundOn.SetActive(false);
            SoundOff.SetActive(true);
            foreach (AudioSource audioSource in audioSources)
            {
                if (audioSource.CompareTag(SoundTag))
                {
                    audioSource.enabled = false; // Vypneme Audio Source s odpovídajícím tagem
                }
            }


        }
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "SoundOff_N")
        {
            Debug.Log("zvukoff");
            SoundOn.SetActive(true);
            SoundOff.SetActive(false);
            foreach (AudioSource audioSource in audioSources)
            {
                if (audioSource.CompareTag(SoundTag))
                {
                    audioSource.enabled = true; // Zapneme Audio Source s odpovídajícím tagem
                }
            }
        }

        if (Input.GetMouseButtonDown(0) && hit.collider.name == "MusicOn_N")
        {
            Debug.Log("hudba");
            MusicOn.SetActive(false);
            MusicOff.SetActive(true);
            foreach (AudioSource audioSource in audioSources)
            {
                if (audioSource.CompareTag(MusicTag))
                {
                    audioSource.enabled = false; // Vypneme Audio Source s odpovídajícím tagem
                }
            }
        }
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "MusicOff_N")
        {
            Debug.Log("hudbaoff");
            MusicOn.SetActive(true);
            MusicOff.SetActive(false);
            foreach (AudioSource audioSource in audioSources)
            {
                if (audioSource.CompareTag(MusicTag))
                {
                    audioSource.enabled = true; // Zapneme Audio Source s odpovídajícím tagem
                }
            }
        }

    }     
}


    