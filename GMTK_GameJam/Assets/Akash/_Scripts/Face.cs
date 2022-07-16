using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    public enum facing
    {
        up,down,left,right,front,back
    }
    [SerializeField]
    private facing facingToward;
}
