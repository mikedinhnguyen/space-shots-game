using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera cam;

    private Vector2 moveDirection;
    private Vector2 mousePos;

    public float moveSpeed;
    private bool spinLeft = true;

    private void Start()
    {
        ScoreKeeper.score = 0;
    }

    void Update()
    {
        ProcessInputs();
        if (Input.GetButtonDown("Fire1") && spinLeft)
        {
            spinLeft = false;
        }
        else if (Input.GetButtonDown("Fire1") && !spinLeft)
        {
            spinLeft = true;
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        //Vector2 lookDir = rb.position - mousePos;
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        //rb.rotation = angle;

        if (spinLeft)
        {
            rb.rotation += 1;
        } else
        {
            rb.rotation -= 1;
        }

    }

}
