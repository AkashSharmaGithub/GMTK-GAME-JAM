using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeCollider : MonoBehaviour
{
    [Header("GameObjects")]
    [SerializeField]
    GameObject piller_of_Tower;
    [SerializeField,Range(0,10f)]
    private float timeToRotate;
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
            float y= piller_of_Tower.transform.rotation.eulerAngles.y;
            // Debug.Log("Something Happened!");
            LeanTween.rotateY(piller_of_Tower, y+90f, timeToRotate);
            //pos.y += 90f;
        }
    }
    private void Update()
    {
        //piller_of_Tower.transform.eulerAngles = pos;
    }
}
