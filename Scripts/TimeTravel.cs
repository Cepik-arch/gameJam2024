using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTravel : MonoBehaviour
{
    public WorldController worldController;
    public Animator animator;
    public GameObject clockShine;

    public AudioSource travelSound;

    public bool canTravel = false;
    public float cooldownTime = 1f;
    private float nextTravelTime = 0f;

    public GameObject dialog;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canTravel && Time.time >= nextTravelTime)
        {
            //clockShine.SetActive(true);
            //animator.SetBool("Shine", true);

            //StartCoroutine(DelayedSceneSwitch(cooldownTime));

            if(travelSound)
            {
                travelSound.Play();
            }

            if(dialog)
            {
                dialog.SetActive(false);
            }

            worldController.ChangeScene();
            nextTravelTime = Time.time + cooldownTime;
        }
    }
    private IEnumerator DelayedSceneSwitch(float delay)
    {
        yield return new WaitForSeconds(delay);
        clockShine.SetActive(false);
        worldController.ChangeScene();
    }
}
