using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI m_scoreText;
    private int score = 0;

    public int GetScore()
    {
        return score;
    }

    public void AddScores(int point)
    {
        score += point;
        Debug.Log("Current score: " + score);
        // this could be handled in a UI manager class insted
        m_scoreText.text = "Score: " + score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
    }


}
