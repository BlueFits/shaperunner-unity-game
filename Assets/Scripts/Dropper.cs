using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigid = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigid.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        renderer = GetComponent<MeshRenderer>();
        rigid = GetComponent<Rigidbody>();

        if (Time.time > 3f) {
            renderer.enabled = true;
            rigid.useGravity = true;
        }
    }
}
