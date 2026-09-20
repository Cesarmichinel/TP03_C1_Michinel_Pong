using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] bool player1Goal;
    public GameObject gamManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (player1Goal)
            {
               gamManager.GetComponent<GameManager>().Player1Score();
            }
            else
            {
                gamManager.GetComponent<GameManager>().Player2Score();
            }


        }
    }
}
