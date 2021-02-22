using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera cam;
    //public Transform playerDir;

    private Vector2 moveDirection;
    private Vector2 mousePos;

    public float moveSpeed;

    //void Start()
    //{
    //    transform.localRotation = Quaternion.identity;
    //}

    void Update()
    {
        ProcessInputs();
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
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void Move()
    {
        Vector2 testDir = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        Vector2 lookDir = rb.position - mousePos;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;

        rb.AddForce(testDir.normalized * moveSpeed * Time.deltaTime, ForceMode2D.Impulse);
        rb.rotation = angle;
    }

}
