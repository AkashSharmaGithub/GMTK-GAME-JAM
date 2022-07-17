using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDownScript : MonoBehaviour
{
    private bool canButtonGoDown,isButtonDown;
    private Vector3 startingPos;
    private float moveY=0.8f;

    private void OnEnable()
    {
        startingPos= transform.position;
        isButtonDown = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("face") )
            {
            Debug.Log("Player Entered");
          
            isButtonDown=true;
        }
    }
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {

    //        LeanTween.moveY(this.gameObject, -moveY, 0.2f);
    //    }
    //}
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("face"))
        {
            Debug.Log("Player moved");
           
            isButtonDown = false;
        }
        

    }
   
}
