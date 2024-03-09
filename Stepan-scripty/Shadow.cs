using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Shadow : MonoBehaviour
{


    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.1f;
    private Rigidbody2D rb;

    public GameObject shadow;
    public float maxHeight = 2f;
    public float maxScale = 0.5f;
     private float initialScale;
      public float raycastDistance = 10f; // Max distance to cast the ray
    public float yOffset = 0.1f; // Offset to ensure the ray starts slightly above the shadow

    private Vector3 initialPosition;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialScale = shadow.transform.localScale.x;
    }

    void Update()
    {   
        maxHeight=transform.position.y +2.5f;

        shadow.transform.position = new Vector3(transform.position.x, shadow.transform.position.y, shadow.transform.position.z);
        float scale = Mathf.Lerp(initialScale, maxScale, transform.position.y / maxHeight);
        shadow.transform.localScale = new Vector3(1f, scale, 1f);

        RaycastHit2D hit = Physics2D.Raycast(transform.position + Vector3.down * yOffset, Vector2.down);

        float transitionSpeed = 5f;

        if (hit.collider != null)
        {Vector3 newPosition = new Vector3(shadow.transform.position.x, hit.point.y, shadow.transform.position.z);
    float height = transform.position.y - hit.point.y;
    
    // Set the shadow's position directly
    shadow.transform.position = newPosition;
        }
    }
}


