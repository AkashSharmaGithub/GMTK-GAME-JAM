using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFallCheck : MonoBehaviour
{
    private bool _checkDoneForTheFirstTime;
    private void OnEnable()
    {
        _checkDoneForTheFirstTime = false;
    } 
    //private void OnCollisionEnter(Collision collision)
    ////{
    ////    if(collision.gameObject.CompareTag("face") && !_checkDoneForTheFirstTime)
    ////    {
    ////        Debug.Log("Chalo be");
    ////        LevelManager.instance.onPLayerLost?.Invoke();
    ////        _checkDoneForTheFirstTime = false;
    ////    }
    //}
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("face") && !_checkDoneForTheFirstTime)
        {
         
            LevelManager.instance.onPLayerLost?.Invoke();
            _checkDoneForTheFirstTime = false;
        }
    }
}
