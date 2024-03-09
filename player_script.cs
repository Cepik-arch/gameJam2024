using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class player_script : MonoBehaviour
{

    public float speed;
    public float jump_speed;

    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.1f;

    public Collider2D platform_CO;
    public Transform platfrom_TR;

    //inventáø
    public static bool pojistka = false;
    public static bool key = false;

    private Rigidbody2D rb;

    public bool hasQuestItem = false;
    public TextMeshProUGUI questText;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Debug.Log(pojistka);

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
        // Zjistï¿½nï¿½, zda se objekt dotï¿½kï¿½ zemï¿½
        return Physics2D.OverlapCircle(groundCheckPosition, groundCheckRadius, groundLayer);
    }

    void OnTriggerEnter2D(Collider2D pojistka2)
    {
        // Zavolï¿½ se, kdyï¿½ tento trigger vstoupï¿½ do jinï¿½ho triggeru nebo kolize
        Debug.Log("Nï¿½co vstoupilo do triggeru.");
    }
}

