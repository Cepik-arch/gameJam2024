using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutSceneController : MonoBehaviour
{
    public string nextSceneName;

    private void Start()
    {
        Invoke("LoadNextScene", GetCutsceneDuration());
    }

    float GetCutsceneDuration()
    {
        VideoPlayer videoPlayer = GameObject.Find("cutsceneVideo").GetComponent<VideoPlayer>();

        return (float)videoPlayer.clip.length;
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}

