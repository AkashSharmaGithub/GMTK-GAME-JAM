using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseHeightofPlatform : MonoBehaviour
{
    private Vector3 pos;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= 0)
        {
            pos.y += moveSpeed;
        }
        transform.position = pos;   
    }
}
