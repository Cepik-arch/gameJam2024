using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class player_script : MonoBehaviour
{
    public float speed;
    public float jump_speed;

    public Animator animator;

    public AudioSource darkSteps = null;
    public AudioSource lightSteps = null;
    private bool isLightStepsPlaying = false;
    private bool isDarkStepsPlaying = false;
    public AudioSource jumpSound = null; 

    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.1f;

    private Rigidbody2D rb;

    public bool hasQuestItem = false;
    public bool hasKey = false;
    public bool pojistka = false;
    public TextMeshProUGUI questText;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = Vector3.right * speed * moveHorizontal * Time.deltaTime;
        transform.Translate(movement);

        animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));

        PlaySound(moveHorizontal);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            if(jumpSound != null)
            {
                jumpSound.Play();
            }
            animator.SetBool("IsJump", true);
            Vector3 jump = Vector3.up * jump_speed;
            GetComponent<Rigidbody2D>().AddForce(jump, ForceMode2D.Impulse);
        }
        
        animator.SetBool("IsJump", !IsGrounded());

        if (moveHorizontal < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (moveHorizontal > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

    }

    public void UpdateQuest()
    {
        questText.text = Variables.currentQuest;
    }
    
    public bool IsGrounded()
    {
        Vector2 groundCheckPosition = new Vector2(groundCheck.position.x, groundCheck.position.y);
        return Physics2D.OverlapCircle(groundCheckPosition, groundCheckRadius, groundLayer);
    }

    private void PlaySound(float moveHorizontal)
    {
        if (lightSteps != null && darkSteps != null )
        {
            if ((Mathf.Abs(moveHorizontal) > 0) && IsGrounded())
            {
                if (!isLightStepsPlaying)
                {
                    lightSteps.Play();
                    isLightStepsPlaying = true;
                }

                if (!isDarkStepsPlaying)
                {
                    darkSteps.Play();
                    isDarkStepsPlaying = true;
                }
            }
            else
            {
                lightSteps.Stop();
                darkSteps.Stop();
                isLightStepsPlaying = false;
                isDarkStepsPlaying = false;
            }
        }
    }

    public void setQuestItem(bool questStatus)
    {
        hasQuestItem = questStatus;
    }

    public void setKey(bool keyStatus)
    {
        hasKey = keyStatus;
    }
}

