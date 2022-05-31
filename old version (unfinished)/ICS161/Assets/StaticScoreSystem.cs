using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StaticScoreSystem : MonoBehaviour
{
    [SerializeField]
    private static TextMeshProUGUI m_hitText;
    private static float numHits = 0;
    [SerializeField]
    private static TextMeshProUGUI m_throwText;
    private static float numthrows = 0;
    [SerializeField]
    private static TextMeshProUGUI m_rateText;
    private static float successRate = 0;

    //num of hits
    public static void AddHits(float point)
    {
        numHits += point;
        Debug.Log("Current hits scores " + numHits);
        // this could be handled in a UI manager class insted
        m_hitText.text = "Num of hits: " + numHits.ToString();
        DisplaySuccessRate();
    }


    //num of throws
    public static void AddThrows(float point)
    {
        numthrows += point;
        Debug.Log("Current throws score: " + numthrows);
        // this could be handled in a UI manager class insted
        m_throwText.text = "Num of throws: " + numthrows.ToString();
        DisplaySuccessRate();
    }


    //success rate
    public static void DisplaySuccessRate()
    {
        if (numthrows == 0)
            successRate = 0;
        else
            successRate = numHits / numthrows * 100;

        successRate = Mathf.Round(successRate * 10.0f) * 0.1f;

        //Debug.Log("Current success rate : " + successRate);
        Debug.Log(numHits + " " + numthrows + " " + successRate);
        // this could be handled in a UI manager class insted
        m_rateText.text = "success rate: " + successRate.ToString() + "%";

    }
}

