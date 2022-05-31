using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Yan Xiao
public class targethit : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Adds 1 point to player's score
            other.GetComponent<ScoreSystem>().AddHits(1f);

        }
    }
}
