using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField]
    float timeToRotate = 45f;
    [SerializeField]
    Vector3 angleRotation;
    void Update()
    {
        transform.Rotate(angleRotation * timeToRotate * Time.deltaTime);
    }
}
