using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationSpeedY = 0.3f;

    void Update()
    {
        transform.Rotate(0f, rotationSpeedY, 0f);
    }
}
