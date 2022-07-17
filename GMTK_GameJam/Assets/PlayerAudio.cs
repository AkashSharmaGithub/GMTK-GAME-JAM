using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
     private AudioSource playerMoveAudio;
    
    // Start is called before the first frame update
    private void OnEnable()
    {
        PlayerMovementComponent.onPlayerMoved += playAudio;
        playerMoveAudio=GetComponent<AudioSource>();
        //playerMovementComponent = GetComponent<PlayerMovementComponent>();
    }
    private void OnDisable()
    {
        PlayerMovementComponent.onPlayerMoved -= playAudio;

    }
    void playAudio()
    {
        playerMoveAudio.Play();
    }

}
