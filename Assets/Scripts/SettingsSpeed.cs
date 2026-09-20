using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsSpeed : MonoBehaviour
{
    [SerializeField] private Slider Sliderplayer1;
    [SerializeField] private Slider Sliderplayer2;

    [SerializeField] private TMP_Text Speedplayer1text;
    [SerializeField] private TMP_Text Speedplayer2text;

    void Start()
    {
        // Inicializa los sliders con el valor guardado en GameSettings
        Sliderplayer1.value = GameSettings.player1Speed;
        Sliderplayer2.value = GameSettings.player2Speed;

        Speedplayer1text.text = GameSettings.player1Speed.ToString();
        Speedplayer2text.text = GameSettings.player2Speed.ToString();

        Sliderplayer1.onValueChanged.AddListener(ChangeSpeedPlayer1);
        Sliderplayer2.onValueChanged.AddListener(ChangeSpeedPlayer2);
    }

    private void ChangeSpeedPlayer1(float newSpeed)
    {
        GameSettings.player1Speed = newSpeed;
        Speedplayer1text.text = newSpeed.ToString();
    }

    private void ChangeSpeedPlayer2(float newSpeed)
    {
        GameSettings.player2Speed = newSpeed;
        Speedplayer2text.text = newSpeed.ToString();
    }
}