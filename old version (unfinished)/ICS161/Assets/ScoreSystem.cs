using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI m_hitText;
    private float numHits = 0;
    [SerializeField]
    private TextMeshProUGUI m_throwText;
    private float numthrows = 0;
    [SerializeField]
    private TextMeshProUGUI m_rateText;
    private float successRate = 0;

    //num of hits
    public void AddHits(float point)
    {
        numHits += point;
        Debug.Log("Current hits scores " + numHits);
        // this could be handled in a UI manager class insted
        m_hitText.text = "Num of hits: " + numHits.ToString();
        DisplaySuccessRate();
    }


    //num of throws
    public void AddThrows(float point)
    {
        numthrows += point;
        Debug.Log("Current throws score: " + numthrows );
        // this could be handled in a UI manager class insted
        m_throwText.text = "Num of throws: " + numthrows.ToString();
        DisplaySuccessRate();
    }


    //success rate
    public void DisplaySuccessRate()
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

   

    //public int getHit()
    //{
    //    return numHits;
    //}

    //public int getHit()
    //{
    //    return numthrows;
    //}

    //private void Update()
    //{
    //    Debug.Log("Current: " + numthrows + " " + numHits);
    //}

    //public int GetHits()
    //{
    //    return numHits;
    //}

    //public void ResetScore()
    //{
    //    numHits = 0;
    //}


}
