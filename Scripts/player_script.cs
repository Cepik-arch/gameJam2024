using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    public Animator animator;

    public float speed;
    public float jump_speed;

    public Collider2D pojistka2;

    public Transform groundCheck;
    public LayerMask groundLayer;
        public LayerMask groundLayer1;
    public float groundCheckRadius = 0.1f;

    public Collider2D platform_CO;
    public Transform platfrom_TR;
    public bool hasQuestItem = false;
    public bool hasKey = false;
    public TextMeshProUGUI questText;
    
    //inventory
    public static bool pojistka = false;
    public static bool key = false;

    private Rigidbody2D rb;

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

        if (Input.GetKeyDown(KeyCode.Space) && (IsGrounded()||IsGrounded1()))
        {
            Vector3 jump = Vector3.up * jump_speed;
            GetComponent<Rigidbody2D>().AddForce(jump, ForceMode2D.Impulse);
            animator.SetBool("IsJump", true);
        }

        if((IsGrounded()||IsGrounded1()))
        {
            animator.SetBool("IsJump", false);
        }

        if (moveHorizontal < 0) // Moving left
        {
            transform.localScale = new Vector3(-1f, 1f, 1f); // Flip sprite horizontally
        }
        else if (moveHorizontal > 0) // Moving right
        {
            transform.localScale = new Vector3(1f, 1f, 1f); // Don't flip sprite
        }
    }

    bool IsGrounded()
    {
        Vector2 groundCheckPosition = new Vector2(groundCheck.position.x, groundCheck.position.y);
        return Physics2D.OverlapCircle(groundCheckPosition, groundCheckRadius, groundLayer);
    }

    public void UpdateQuest()
    {
        questText.text = Variables.currentQuest;
    }

    public bool IsGrounded1()
    {
        Vector2 groundCheckPosition = new Vector2(groundCheck.position.x, groundCheck.position.y);
        return Physics2D.OverlapCircle(groundCheckPosition, groundCheckRadius, groundLayer1);
    }

}

