using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class GoDownScript : MonoBehaviour
{
    private AudioSource _clickAudio;
    private bool canButtonGoDown,isButtonDown;
    private Vector3 startingPos;
    private float moveY=0.8f;
    [SerializeField]
    private GameObject btn;
    private void Awake()
    {
        startingPos = btn.transform.position;
       _clickAudio=GetComponent<AudioSource>();
        
}
    private void OnEnable()
    {

          btn.transform.position=startingPos;
          isButtonDown = false;
        
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("face") && isButtonDown==false)
            {
            _clickAudio.Play();
            Debug.Log("Player Entered");
            LeanTween.moveY(btn, -moveY, 0.2f);
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
        if(other.gameObject.CompareTag("face") && isButtonDown == true)
        {
            Debug.Log("Player moved");
            LeanTween.moveY(btn, startingPos.y, 0.2f);
            _clickAudio.Play();
            isButtonDown = false;
        }
        

    }
   
}
