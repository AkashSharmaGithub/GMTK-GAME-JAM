using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawn_Platform : MonoBehaviour
{
    public UnityEvent onPlatformSpawn;
    [SerializeField]
    GameObject _sp;
    [SerializeField]
    GameObject spawn_Trasnform;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
            //InstantiantePlatform();
            onPlatformSpawn.Invoke();
        }
    }
    public void InstantiantePlatform()
    {
        Instantiate(_sp, spawn_Trasnform.transform);
    }
}
