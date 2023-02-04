using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 10.0f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        rb.velocity = movement * speed;
    }
}