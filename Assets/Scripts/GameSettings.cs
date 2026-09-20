using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "Pong/Game Settings")]
public class GameSettings : ScriptableObject
{
    [Header("Paddles")]
    public float player1Speed = 3f;
    public float player2Speed = 3f;
    public float player1PaddleHeight = 1f;
    public float player2PaddleHeight = 1f;

    [Header("Reglas de partida")]
    public int pointsToWin = 3;

    [Header("Timer de gol")]
    public float goalTimeLimit = 20f;
}