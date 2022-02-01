using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    [SerializeField] float moveSpeed = 7f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        MovePlayer();
    }    
    
    void MovePlayer() {
        float xIn = (Input.GetAxis("Horizontal") * Time.deltaTime) * moveSpeed;
        float zIn = (Input.GetAxis("Vertical") * Time.deltaTime) * moveSpeed;
        transform.Translate(xIn, 0, zIn);
    }
}
