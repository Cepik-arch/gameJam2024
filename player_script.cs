using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class player_script : MonoBehaviour
{
    public float speed;
    public float jump_speed;

    public Collider2D pojistka2;

    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.1f;

    private Rigidbody2D rb;

    public bool hasQuestItem = false;
    public TextMeshProUGUI questText;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");

        //Debug.Log(moveHorizontal);
        //Debug.Log(IsGrounded());

        Vector3 movement = Vector3.right * speed * moveHorizontal * Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Vector3 jump = Vector3.up * jump_speed;
            GetComponent<Rigidbody2D>().AddForce(jump, ForceMode2D.Impulse);
        }
    }

    public void UpdateQuest()
    {
        questText.text = Variables.currentQuest;
    }
    
    bool IsGrounded()
    {
        Vector2 groundCheckPosition = new Vector2(groundCheck.position.x, groundCheck.position.y);
        // Zjist�n�, zda se objekt dot�k� zem�
        return Physics2D.OverlapCircle(groundCheckPosition, groundCheckRadius, groundLayer);
    }

    void OnTriggerEnter2D(Collider2D pojistka2)
    {
        // Zavol� se, kdy� tento trigger vstoup� do jin�ho triggeru nebo kolize
        Debug.Log("N�co vstoupilo do triggeru.");
    }
}

