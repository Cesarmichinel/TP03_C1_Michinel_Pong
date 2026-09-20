using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameSettings gameSettings;

    [SerializeField] GameObject ball;
    [SerializeField] GameObject player1;
    [SerializeField] GameObject left;
    [SerializeField] GameObject player2;
    [SerializeField] GameObject right;

    public TMP_Text player1Text;
    public TMP_Text player2Text;

    [SerializeField] private GameObject victoryPanel;
    public TMP_Text winnerText;

    private int player1Score;
    private int player2Score;

    private float goalTimer;
    private bool gameOver;

    private void Start()
    {
        goalTimer = gameSettings.goalTimeLimit;
        if (victoryPanel != null) victoryPanel.SetActive(false);
    }

    private void EndGame(string winnerName)
    {
        gameOver = true;
        ball.SetActive(false);

        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true);
            winnerText.text = winnerName + " ganó!";
        }

    }

    private void Update()
    {
        if (gameOver) return;

        goalTimer -= Time.deltaTime;
        if (goalTimer <= 0f)
        {
            HandleTimeout();
        }
    }

    private void HandleTimeout()
    {
        float centerX = (left.transform.position.x + right.transform.position.x) / 2f;

        if (ball.transform.position.x < centerX)
        {
            Player2Score();
        }
        else
        {
            Player1Score();
        }
    }

    public void Player1Score()
    {
        if (gameOver) return;

        player1Score++;
        player1Text.text = player1Score.ToString();

        if (player1Score >= gameSettings.pointsToWin)
        {
            EndGame("Player 1");
            return;
        }

        ResetPosition();
    }

    public void Player2Score()
    {
        if (gameOver) return;

        player2Score++;
        player2Text.text = player2Score.ToString();

        if (player2Score >= gameSettings.pointsToWin)
        {
            EndGame("Player 2");
            return;
        }

        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1.GetComponent<Movement>().Reset();
        player2.GetComponent<Movement>().Reset();

        goalTimer = gameSettings.goalTimeLimit; 
    }

     
}