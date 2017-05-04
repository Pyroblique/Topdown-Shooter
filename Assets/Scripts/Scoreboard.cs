using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{

    public static int score = 0;
    public static int lives = 15;

    // Scoreboard
    void OnGUI()
    {
        float scrW = Screen.width / 16;
        float scrH = Screen.height / 9;

        GUI.Box(new Rect(scrW, 1f * scrH, scrW, 0.5f * scrH), "Score");
        GUI.Box(new Rect(scrW, 2f * scrH, scrW, 0.5f * scrH), "Lives");
        GUI.Box(new Rect(2 * scrW, 1f * scrH, scrW, 0.5f * scrH), score.ToString());
        GUI.Box(new Rect(2 * scrW, 2f * scrH, scrW, 0.5f * scrH), lives.ToString());
    }
}
