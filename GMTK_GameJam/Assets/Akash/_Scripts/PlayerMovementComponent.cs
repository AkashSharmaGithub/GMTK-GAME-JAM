using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(InputHandlerScript))]
public class PlayerMovementComponent : MonoBehaviour
{
    [SerializeField]private float _rollSpeed;
    private InputHandlerScript _inputhandler;
    private bool _isMoving;

    private void OnEnable()
    {
        _inputhandler = GetComponent<InputHandlerScript>();
        _isMoving = false;
        _inputhandler.onLeftButtonClicked += move;
        _inputhandler.onRightButtonClicked += move;
        _inputhandler.onUpButtonClicked += move;
        _inputhandler.onDownButtonClicked += move;
    }
    private void OnDisable()
    {
        _inputhandler.onLeftButtonClicked -= move;
        _inputhandler.onRightButtonClicked -= move;
        _inputhandler.onUpButtonClicked -= move;
        _inputhandler.onDownButtonClicked -= move;
    }
   
    private void move(Vector3 dir)
    {
        Vector3 anchor = transform.position + (Vector3.down + dir) * 0.5f;
        Vector3 axis = Vector3.Cross(Vector3.up, dir);
        if(_isMoving==false)
        StartCoroutine(Roll(anchor, axis));

    }
    IEnumerator Roll(Vector3 anchor ,Vector3 axis)
    {
        _isMoving=true;
        for(int i=0; i<90/_rollSpeed;i++)
        {
            transform.RotateAround(anchor, axis, _rollSpeed);
            yield return new WaitForSeconds(0.01f);
        }
        _isMoving=false;
    }

}
