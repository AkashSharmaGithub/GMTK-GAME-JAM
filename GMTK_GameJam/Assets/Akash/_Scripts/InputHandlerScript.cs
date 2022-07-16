using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class InputHandlerScript : MonoBehaviour
{
    public Action<Vector3> onLeftButtonClicked,onRightButtonClicked, onUpButtonClicked,onDownButtonClicked;
     

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W))
        {
            onUpButtonClicked?.Invoke(Vector3.forward);
        }
        if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S))
        {
            onDownButtonClicked?.Invoke(Vector3.back);
        }
        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            onLeftButtonClicked?.Invoke(Vector3.left);
        }
        if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
            onRightButtonClicked?.Invoke(Vector3.right);
        }
    }
}
