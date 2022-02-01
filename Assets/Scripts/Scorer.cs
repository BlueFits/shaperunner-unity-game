using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit") {
            hits++;
            Debug.Log("Hit wall: " + hits);
        }
    }
}
