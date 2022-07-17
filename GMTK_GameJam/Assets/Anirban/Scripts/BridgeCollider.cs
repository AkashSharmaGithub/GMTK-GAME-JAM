using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeCollider : MonoBehaviour
{
    [Header("GameObjects")]
    [SerializeField]
    GameObject piller_of_Tower;
    LTDescr ltdDes;
    [SerializeField]
    float degreeToTurn =90f;
    [SerializeField]
    float timeToAnimate = 4f;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("Something Happened!");
            if (ltdDes == null || !LeanTween.isTweening(ltdDes.id))
            {
                ltdDes = LeanTween.rotateY(piller_of_Tower,piller_of_Tower.transform.eulerAngles.y + degreeToTurn, timeToAnimate);
            }

        }
    }
 
}
