using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Child : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject dialogWindow;

    public player_script playerS;
    public List<string> childQuest = new List<string>() { };
    public int textCounter = 0;
    public float speed = 2.0f;
    public bool moveRight = true;
    private Vector3 ogTransform;
    private bool isMoving = true;
    

    public Animator animator;
    void Start()
    {
        ogTransform = transform.position;
        text.enabled = false;
        NpcWalk();
    }

    private void NpcWalk()
    {
        if (moveRight)
        {
            Vector3 movement = Vector3.right * speed * 1 * Time.deltaTime;
            transform.localScale = new Vector3(1f, 1f, 1f);
            transform.Translate(movement);
        }
        else
        {
            Vector3 movement = Vector3.right * speed * -1 * Time.deltaTime;
            transform.localScale = new Vector3(-1f, 1f, 1f);
            transform.Translate(movement);
        }

        if(animator != null)
        {
            animator.SetFloat("Speed", speed);
        }
    }

    void Update()
    {
        if (isMoving)
        {
            NpcWalk();
            if (transform.position.x > ogTransform.x + 2)
            {
                StartCoroutine(ChangeDirectionWithDelay(1f));
                return;
            }
            if (transform.position.x < ogTransform.x - 2)
            {
                StartCoroutine(ChangeDirectionWithDelay(1f));
                return;
            }
        }
    }

    IEnumerator ChangeDirectionWithDelay(float delay)
    {
        isMoving = false;
        yield return new WaitForSeconds(delay);
        moveRight = !moveRight;
        isMoving = true;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Child: " + text);
        dialogWindow.SetActive(true);
        text.enabled = true;
        isMoving = false;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        dialogWindow.SetActive(false);
        text.enabled = false;
        isMoving = true;
    }

    public void OnClickChangeText()
    {
        if (textCounter == -1)
        {
            return;
        }
        text.text = childQuest[textCounter];
        textCounter++;
        Debug.Log(textCounter);
        if (textCounter == 2)
        {
            Variables.currentQuest = "Find and Bring Teddybear to child";
            playerS.UpdateQuest();
        }
        if (textCounter == 3)
        {
            textCounter--;
        }
        if (playerS.hasQuestItem == true)
        {
            Variables.currentQuest = "";
            text.text = "Thanks for saving my friend. Here is some key that I found here...";
            playerS.hasQuestItem = false;
            playerS.hasKey = true;
            playerS.UpdateQuest();
            textCounter = -1;

            StartCoroutine(Wait());

        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        dialogWindow.SetActive(false);
    }
}
