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
        if(Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.W))
        {
            onUpButtonClicked?.Invoke(Vector3.forward);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.S))
        {
            onDownButtonClicked?.Invoke(Vector3.back);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.A))
        {
            onLeftButtonClicked?.Invoke(Vector3.left);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.D))
        {
            onRightButtonClicked?.Invoke(Vector3.right);
        }
    }
}
