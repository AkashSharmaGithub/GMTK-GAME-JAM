using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeCollider : MonoBehaviour
{
    [Header("GameObjects")]
    [SerializeField]
    GameObject piller_of_Tower;

    private Vector3 pos;
    //private float x, y, z;
    private void Start()
    {
        //x = piller_of_Tower.transform.eulerAngles.x;
        //y = piller_of_Tower.transform.eulerAngles.y;
        //z = piller_of_Tower.transform.eulerAngles.z;
        //pos.x = x;
        //pos.y = y;
        //pos.z = z;
        pos =piller_of_Tower.transform.eulerAngles;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("Something Happened!");
            pos.y += 90f;
        }
    }
    private void Update()
    {
        piller_of_Tower.transform.eulerAngles = pos;
    }
}
