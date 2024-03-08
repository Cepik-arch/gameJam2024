using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    private bool timerOn = true;

    public float time = 60f;
    private float timeReal;
    public GameObject testObject;
    public GameObject checkpoint;

    void Start()
    {
        timer.text = time.ToString("0.00");
        timeReal = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn == true)
        {
            timeReal -= Time.deltaTime;
            timer.text = timeReal.ToString("0.00");
        }

        if (timeReal < 0 )
        {
            timerEnds();
        }
    }

    public void timerEnds()
    {
        timeReal = time;
        testObject.transform.position = checkpoint.transform.position;

    }
}
