using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsSize : MonoBehaviour
{
    [SerializeField] private GameSettings gameSettings;

    [SerializeField] private Slider Sliderplayer1;
    [SerializeField] private Slider Sliderplayer2;

    [SerializeField] private TMP_Text Sizeplayer1text;
    [SerializeField] private TMP_Text Sizeplayer2text;

    void Start()
    {
        Sliderplayer1.value = gameSettings.player1PaddleHeight;
        Sliderplayer2.value = gameSettings.player2PaddleHeight;

        Sizeplayer1text.text = gameSettings.player1PaddleHeight.ToString();
        Sizeplayer2text.text = gameSettings.player2PaddleHeight.ToString();

        Sliderplayer1.onValueChanged.AddListener(ChangeSizePlayer1);
        Sliderplayer2.onValueChanged.AddListener(ChangeSizePlayer2);
    }

    private void ChangeSizePlayer1(float newSize)
    {
        gameSettings.player1PaddleHeight = newSize;
        Sizeplayer1text.text = newSize.ToString();
    }

    private void ChangeSizePlayer2(float newSize)
    {
        gameSettings.player2PaddleHeight = newSize;
        Sizeplayer2text.text = newSize.ToString();
    }
}