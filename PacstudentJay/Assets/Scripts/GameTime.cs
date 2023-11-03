using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTime : MonoBehaviour
{
    public float gameTime = 0f;
    public TextMeshProUGUI timeText;

    void Update()
    {
        gameTime += Time.deltaTime;

        int hours = Mathf.FloorToInt(gameTime / 3600f);
        int minutes = Mathf.FloorToInt((gameTime % 3600f) / 60f);
        int seconds = Mathf.FloorToInt(gameTime % 60f);

        string timeString = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);

        timeText.text = "Game Time: " + timeString;
    }
}
