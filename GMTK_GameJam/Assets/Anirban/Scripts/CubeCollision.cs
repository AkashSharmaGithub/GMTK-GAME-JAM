using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class CubeCollision : MonoBehaviour
{
    public UnityEvent onButtonCollision;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            onButtonCollision.Invoke(); 
        }
    }
}
