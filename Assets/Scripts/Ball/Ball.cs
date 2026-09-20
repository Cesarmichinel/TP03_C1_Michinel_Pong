using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float initialSpeed = 7f;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
        Launch();
    }

    public void Reset()
    {
        transform.position = startPos;
        rb.linearVelocity = Vector2.zero;
        Launch();
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        Vector2 direction = new Vector2(x, y).normalized;

        rb.linearVelocity = Vector2.zero;
        rb.AddForce(direction * initialSpeed, ForceMode2D.Impulse);
    }
}