using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTargetHits : MonoBehaviour
{
    [SerializeField]
    private GameObject character;//???

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Breakable")
        {
            // Adds 1 point to player's score
            character.GetComponent<ScoreSystem>().AddHits(1f);
        }
    }
}
