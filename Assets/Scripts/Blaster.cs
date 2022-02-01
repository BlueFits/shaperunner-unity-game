// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using System;

public class Blaster : MonoBehaviour
{
    [SerializeField] float force = 800.0f;
    [SerializeField] int randomizeTimer = 4;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("blast", 0, randomizeTimer);
    }

    void blast() {
        double range = Math.Floor(UnityEngine.Random.Range(0.0f, 4.0f));

        switch(range) {
            case 0:
                this.GetComponent<Rigidbody>().AddForce(Vector3.right*force);
                break;
            case 1: 
                this.GetComponent<Rigidbody>().AddForce(Vector3.left*force);
                break;
            case 2: 
                this.GetComponent<Rigidbody>().AddForce(Vector3.back*force);
                break;
            case 3:
                this.GetComponent<Rigidbody>().AddForce(Vector3.forward*force);
                break;    
            default:
                this.GetComponent<Rigidbody>().AddForce(Vector3.right*force);
                break;
        }
    }
}
