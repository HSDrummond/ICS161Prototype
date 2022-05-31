using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targethit : MonoBehaviour
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


    //===============================================================
    //private bool collected = false;


    //[SerializeField]
    //private GameObject character;//???

    //public void OnTriggerEnter(Collider other)
    //{

    //    if (!collected &&  other.gameObject.tag == "Breakable")
    //    {
    //        // Adds 1 point to player's score
    //        character.GetComponent<ScoreSystem>().AddHits(1f);
    //        collected = true;
    //        StartCoroutine(Reset());
    //    }
    //}


    //IEnumerator Reset()
    //{
    //    yield return new WaitForEndOfFrame();
    //    collected = false;
    //}




    //=====================================================
    //[SerializeField]
    //private GameObject character;//???
    //List<GameObject> pickups = new List<GameObject>();

    //public void OnTriggerEnter(Collider other)
    //{

    //    if (!pickups.Contains(other.gameObject) && other.gameObject.tag == "Breakable")
    //    {
    //        // Adds 1 point to player's score
    //        character.GetComponent<ScoreSystem>().AddHits(1f);
    //        pickups.Add(other.gameObject);
    //    }
    //}
    //void resetPickupsList()
    //{
    //    pickups.Clear();
    //}


    //=====================================================
    //[SerializeField]
    //private GameObject character;//???
    //private int i = 0;


    //public void OnTriggerEnter(Collider other)
    //{

    //    if (i == 0 && other.gameObject.tag == "Breakable")
    //    {
    //        // Adds 1 point to player's score
    //        character.GetComponent<ScoreSystem>().AddHits(1f);
    //        i = i + 1;
    //    }
    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if (i == 1 && other.gameObject.tag == "Breakable")
    //    {
    //        // Adds 1 point to player's score
    //        character.GetComponent<ScoreSystem>().AddHits(1f);
    //        i = 0;
    //    }

    //}
}
