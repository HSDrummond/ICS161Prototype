using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targethit : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Adds 10 point to player's score
            other.GetComponent<ScoreSystem>().AddScores(10);

        }
    }
}
