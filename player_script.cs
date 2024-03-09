using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    
    bool IsGrounded()
    {
        Vector2 groundCheckPosition = new Vector2(groundCheck.position.x, groundCheck.position.y);
        // Zjistìní, zda se objekt dotýká zemì
        return Physics2D.OverlapCircle(groundCheckPosition, groundCheckRadius, groundLayer);
    }






}

