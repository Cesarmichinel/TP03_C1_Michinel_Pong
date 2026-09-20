using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private bool player1; // true = WASD, false = Flechas
    [SerializeField] public float speed = 3f;
    [SerializeField] private Rigidbody2D rb;

    private float moveX;
    private float moveY;
    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
        speed = player1 ? GameSettings.player1Speed : GameSettings.player2Speed;

        float height = player1 ? GameSettings.player1PaddleHeight : GameSettings.player2PaddleHeight;
        transform.localScale = new Vector3(height, transform.localScale.y, transform.localScale.z);
    }

    void Update()
    {
        moveX = 0;
        moveY = 0;

        if (player1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveY = 1;
            }

            if (Input.GetKey(KeyCode.S))
            {
                moveY = -1;
            }

            if (Input.GetKey(KeyCode.A))
            {
                moveX = -1;
            }

            if (Input.GetKey(KeyCode.D))
            {
                moveX = 1;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                moveY = 1;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                moveY = -1;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                moveX = -1;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                moveX = 1;
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 direction = new Vector2(moveX, moveY);
        Vector2 targetPosition = rb.position + direction * speed * Time.fixedDeltaTime;
        rb.MovePosition(targetPosition);
    }

    public void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = startPos;
    }
}