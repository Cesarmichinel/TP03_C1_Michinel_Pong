using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private bool player1; // true = WASD, false = Flechas
    [SerializeField] private GameSettings gameSettings;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float maxSpeed = 8f;

    private float speed;
    private float moveX;
    private float moveY;
    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
        speed = player1 ? gameSettings.player1Speed : gameSettings.player2Speed;

        float height = player1 ? gameSettings.player1PaddleHeight : gameSettings.player2PaddleHeight;
        transform.localScale = new Vector3(height, transform.localScale.y, transform.localScale.z);
    }

    void Update()
    {
        moveX = 0;
        moveY = 0;

        if (player1)
        {
            if (Input.GetKey(KeyCode.W)) moveY = 1;
            if (Input.GetKey(KeyCode.S)) moveY = -1;
            if (Input.GetKey(KeyCode.A)) moveX = -1;
            if (Input.GetKey(KeyCode.D)) moveX = 1;
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow)) moveY = 1;
            if (Input.GetKey(KeyCode.DownArrow)) moveY = -1;
            if (Input.GetKey(KeyCode.LeftArrow)) moveX = -1;
            if (Input.GetKey(KeyCode.RightArrow)) moveX = 1;
        }
    }

    void FixedUpdate()
    {
        Vector2 direction = new Vector2(moveX, moveY).normalized;
        rb.AddForce(direction * speed, ForceMode2D.Force);

        if (rb.linearVelocity.magnitude > maxSpeed)
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
    }

    public void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = startPos;
    }
}