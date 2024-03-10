using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_game : MonoBehaviour
{
    public Transform Camera_TR;
    /*
    public GameObject paused_GO;
    public GameObject MusicOn;
    public GameObject MusicOff;
    public GameObject SoundOn;
    public GameObject SoundOff;

    public GameObject paused_GO_N;
    public GameObject MusicOn_N;
    public GameObject MusicOff_N;
    public GameObject SoundOn_N;
    public GameObject SoundOff_N;*/

    public GameObject paused_GO_D;
    public GameObject paused_GO_N;

    public GameObject Play_D;
    public GameObject Exit_D;
    public GameObject MusicOn_D;
    public GameObject MusicOff_D;
    public GameObject SoundOn_D;
    public GameObject SoundOff_D;


    public bool paused = false;
    public bool music = true;
    public bool sound = true;

    //audio
    AudioSource[] audioSources = FindObjectsOfType<AudioSource>();
    public string SoundTag = "Sounds";
    public string MusicTag = "Music";

    void Start()
    {
        /*
        paused_GO_D.SetActive(false);
        paused_GO_N.SetActive(false);

        SoundOff_D.SetActive(false);
        MusicOff:D.SetActive(false);

        SoundOff_N.SetActive(false);
        MusicOn_N.SetActive(false);*/
        if (sound == true)
        {
            SoundOn_D.SetActive(true);
            SoundOff_D.SetActive(false);
        }
        else
        {
            SoundOn_D.SetActive(false); 
            SoundOff_D.SetActive(true);
        }

        if (music == true)
        {
            MusicOn_D.SetActive(true);
            MusicOff_D.SetActive(false);
        }
        else
        {
            MusicOn_D.SetActive(false);
            MusicOff_D.SetActive(true);
        }
    }

    ////////////  buttons pro destroyed world
    public void Button_Play_D(GameObject Play_D)
    {
        Debug.Log("Tla��tko bylo zm��knuto! play_d");
        if (Variables.realm == 0)
        {
            Debug.Log("Hra byla odpauznuta");
            paused_GO_D.SetActive(false);
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
    public void Button_Exit_D(GameObject Exit_D)
    {
        Debug.Log("Hra byla ukon�ena.");
        Application.Quit();
    }
    public void Button_MusicOn_D(GameObject MusicOn_D)
    {
        Debug.Log("hudbaon");
        music = false;
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.CompareTag(MusicTag))
            {
                audioSource.enabled = false; // Vypneme Audio Source s odpov�daj�c�m tagem
            }
        }
    }

    public void Button_MusicOff_D(GameObject MusicOff_D)
    {
        Debug.Log("hudbaoff");
        music = true;
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.CompareTag(MusicTag))
            {
                audioSource.enabled = true; // Zapneme Audio Source s odpov�daj�c�m tagem
            }
        }
    }

    public void Button_SoundOn_D(GameObject SoundOn_D)
    {

        Debug.Log("zvukOn");
        sound = false;
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.CompareTag(SoundTag))
            {
                audioSource.enabled = false; // Vypneme Audio Source s odpov�daj�c�m tagem
            }
        }
    }
    public void Button_SoundOff_D(GameObject SoundOff_D)
    {
        Debug.Log("zvukOff");
        sound = true;
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.CompareTag(SoundTag))
            {
                audioSource.enabled = false; // Vypneme Audio Source s odpov�daj�c�m tagem
            }
        }
    }



    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Variables.realm == 0)
            {
                Debug.Log("Paused");
                Time.timeScale = 0;
                paused = true;
                paused_GO_D.SetActive(true);
            }/*
            else if (Variables.realm == 1)
            {
                Debug.Log("Paused");
                Time.timeScale = 0;
                paused = true;
                paused_GO_N.SetActive(true);
            }*/
        }

        // kontrola jestli je zapnut� zvuk a ikonek audia ve h�e

        if (sound == true && Variables.realm == 0)
        {
            Debug.Log(sound);
            SoundOn_D.SetActive(true);
            SoundOff_D.SetActive(false);
        }
        else if (sound == false && Variables.realm == 0)
        {
            Debug.Log(sound);
            SoundOff_D.SetActive(true);
            SoundOn_D.SetActive(false);
        }

        if (music == true && Variables.realm == 0)
        {
            Debug.Log(music);
            MusicOn_D.SetActive(true);
            MusicOff_D.SetActive(false);
        }
        else if (music == false && Variables.realm == 0)
        {
            Debug.Log(sound);
            MusicOff_D.SetActive(true);
            MusicOn_D.SetActive(false);
        }

        /*
        ///////////////// pause menu pro zni�en� sv�t

        // pokra�ov�n� ve h�e
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
        //ukon�en� hry
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "Exit_D")
        {
            Debug.Log("Hra byla ukon�ena.");
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
                    audioSource.enabled = false; // Vypneme Audio Source s odpov�daj�c�m tagem
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
                    audioSource.enabled = true; // Zapneme Audio Source s odpov�daj�c�m tagem
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
                    audioSource.enabled = false; // Vypneme Audio Source s odpov�daj�c�m tagem
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
                    audioSource.enabled = true; // Zapneme Audio Source s odpov�daj�c�m tagem
                }
            }
        }

        //////////////// pause menu pro dobr� sv�t

        // pokra�ov�n� ve h�e
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
        //ukon�en� hry
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "Exit_N")
        {
            Debug.Log("Hra byla ukon�ena.");
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
                    audioSource.enabled = false; // Vypneme Audio Source s odpov�daj�c�m tagem
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
                    audioSource.enabled = true; // Zapneme Audio Source s odpov�daj�c�m tagem
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
                    audioSource.enabled = false; // Vypneme Audio Source s odpov�daj�c�m tagem
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
                    audioSource.enabled = true; // Zapneme Audio Source s odpov�daj�c�m tagem
                }
            }
        }*/


    }
}


