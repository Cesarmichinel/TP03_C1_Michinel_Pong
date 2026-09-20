using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{ 
    [SerializeField] GameObject ball;
    [SerializeField] GameObject player1;
    [SerializeField] GameObject left;
    [SerializeField] GameObject player2;
    [SerializeField] GameObject right;

    public TMP_Text player1Text;
    public TMP_Text player2Text;

    private int player1Score;
    private int player2Score;

    public void Player1Score()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        ResetPosition();
    }

    public void Player2Score()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
       ball.GetComponent<Ball>().Reset();
        player1.GetComponent<Movement>().Reset();
        player2.GetComponent<Movement>().Reset();
    }
}
