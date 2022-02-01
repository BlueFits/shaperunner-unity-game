using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour {
    private Color newColor = new Color(0.820f, 0.886f, 1.000f);

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
    // private void OnCollisionExit(Collision other) {
    //     if (other.gameObject.tag == "Player") {
    //         GetComponent<MeshRenderer>().material.color = newColor;
    //     }
    // }
}