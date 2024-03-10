using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_game : MonoBehaviour
{
    public Transform Camera_TR;

    public GameObject paused_GO_D;
    public GameObject paused_GO_N;

    //pause game pro znièený svìt
    public GameObject Play_D;
    public GameObject Exit_D;
    public GameObject MusicOn_D;
    public GameObject MusicOff_D;
    public GameObject SoundOn_D;
    public GameObject SoundOff_D;

    //pause game pro normální svìt
    public GameObject Play_N;
    public GameObject Exit_N;
    public GameObject MusicOn_N;
    public GameObject MusicOff_N;
    public GameObject SoundOn_N;
    public GameObject SoundOff_N;


    public bool music = true;
    public bool sound = true;

    //audio
    AudioSource[] audioSources = FindObjectsOfType<AudioSource>();
    public string SoundTag = "Sounds";
    public string MusicTag = "Music";

    void Start()
    {
        paused_GO_D.SetActive(false);
        paused_GO_N.SetActive(false);
    }

    ////////////  buttons pro destroyed world
    public void Button_Play_D(GameObject Play_D)
    {
        Debug.Log("Tlaèítko bylo zmáèknuto! play_d");
        if (Variables.realm == 0)
        {
            Debug.Log("Hra byla odpauznuta");
            paused_GO_D.SetActive(false);
            Time.timeScale = 1;
        }
        else if (Variables.realm == 1)
        {
            Debug.Log("Hra byla odpauznuta");
            paused_GO_N.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Button_Exit_D(GameObject Exit_D)
    {
        Debug.Log("Hra byla ukonèena.");
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
                audioSource.enabled = false; // Vypneme Audio Source s odpovídajícím tagem
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
                audioSource.enabled = true; // Zapneme Audio Source s odpovídajícím tagem
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
                audioSource.enabled = false; // Vypneme Audio Source s odpovídajícím tagem
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
                audioSource.enabled = false; // Vypneme Audio Source s odpovídajícím tagem
            }
        }
    }

    ////////////  buttons pro normal world
    public void Button_Play_N(GameObject Play_N)
    {
        Debug.Log("Tlaèítko bylo zmáèknuto! play_d");
        if (Variables.realm == 0)
        {
            Debug.Log("Hra byla odpauznuta");
            paused_GO_D.SetActive(false);
            Time.timeScale = 1;
        }
        else if (Variables.realm == 1)
        {
            Debug.Log("Hra byla odpauznuta");
            paused_GO_N.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Button_Exit_N(GameObject Exit_N)
    {
        Debug.Log("Hra byla ukonèena.");
        Application.Quit();
    }
    public void Button_MusicOn_N(GameObject MusicOn_N)
    {
        Debug.Log("hudbaon");
        music = false;
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.CompareTag(MusicTag))
            {
                audioSource.enabled = false; // Vypneme Audio Source s odpovídajícím tagem
            }
        }
    }

    public void Button_MusicOff_N(GameObject MusicOff_N)
    {
        Debug.Log("hudbaoff");
        music = true;
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.CompareTag(MusicTag))
            {
                audioSource.enabled = true; // Zapneme Audio Source s odpovídajícím tagem
            }
        }
    }

    public void Button_SoundOn_N(GameObject SoundOn_N)
    {

        Debug.Log("zvukOn");
        sound = false;
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.CompareTag(SoundTag))
            {
                audioSource.enabled = false; // Vypneme Audio Source s odpovídajícím tagem
            }
        }
    }
    public void Button_SoundOff_N(GameObject SoundOff_N)
    {
        Debug.Log("zvukOff");
        sound = true;
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.CompareTag(SoundTag))
            {
                audioSource.enabled = false; // Vypneme Audio Source s odpovídajícím tagem
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
                paused_GO_D.SetActive(true);
            }
            else if (Variables.realm == 1)
            {
                Debug.Log("Paused");
                Time.timeScale = 0;
                paused_GO_N.SetActive(true);
            }
        }

        // kontrola jestli je zapnutý zvuk a ikonek audia ve høe

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
        ///////////
        if (sound == true && Variables.realm == 1)
        {
            Debug.Log(sound);
            SoundOn_N.SetActive(true);
            SoundOff_N.SetActive(false);
        }
        else if (sound == false && Variables.realm == 1)
        {
            Debug.Log(sound);
            SoundOff_N.SetActive(true);
            SoundOn_N.SetActive(false);
        }

        if (music == true && Variables.realm == 1)
        {
            Debug.Log(music);
            MusicOn_N.SetActive(true);
            MusicOff_N.SetActive(false);
        }
        else if (music == false && Variables.realm == 1)
        {
            Debug.Log(sound);
            MusicOff_N.SetActive(true);
            MusicOn_N.SetActive(false);
        }


    }
}


