using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseHeightofPlatform : MonoBehaviour
{
    public float moveSpeed;
    [SerializeField]
    float timeToReach;
    private void OnEnable()
    {
        LeanTween.moveLocalY(gameObject, 0, timeToReach).setEase(LeanTweenType.easeInSine);
    }
}
