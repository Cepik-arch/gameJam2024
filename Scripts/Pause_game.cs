using UnityEngine;

public class Pause_game : MonoBehaviour
{
    public Transform Camera_TR;

    public GameObject paused_GO_N;

    //pause game pro normální svìt
    public GameObject Play_N;
    public GameObject Exit_N;
    public GameObject SoundOn_N;
    public GameObject SoundOff_N;

    public bool sound = true;

    private AudioSource[] audioSources;
    public string SoundTag = "Sounds";

    void Start()
    {
        //audio
        audioSources = FindObjectsOfType<AudioSource>();
        paused_GO_N.SetActive(false);
    }

    public void Button_Play_N()
    {
        Debug.Log("Hra byla odpauznuta");
        paused_GO_N.SetActive(false);
        Time.timeScale = 1;
    }
    public void Button_Exit_N()
    {
        Debug.Log("Hra byla ukonèena.");
        Application.Quit();
    }
    public void Button_SoundOn_N()
    {

        Debug.Log("zvukOn");
        sound = false;
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.CompareTag(SoundTag))
            {
                audioSource.enabled = false;
            }
        }
    }
    public void Button_SoundOff_N()
    {
        Debug.Log("zvukOff");
        sound = true;
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.CompareTag(SoundTag))
            {
                audioSource.enabled = false;
            }
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            paused_GO_N.SetActive(true);

        }

        if (sound == true)
        {
            Debug.Log(sound);
            SoundOn_N.SetActive(true);
            SoundOff_N.SetActive(false);
        }
        else
        {
            Debug.Log(sound);
            SoundOff_N.SetActive(true);
            SoundOn_N.SetActive(false);
        }

    }
}


