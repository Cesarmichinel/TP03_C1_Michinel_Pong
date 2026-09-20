using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 startPos;

    void Start()
    {
        transform.position = startPos;
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

        rb.linearVelocity = new Vector2(speed * x, speed * y);
    }
}
