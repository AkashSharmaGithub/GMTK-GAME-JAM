using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinButton : MonoBehaviour
{
   [SerializeField] private MeshRenderer _btnColor;
    [SerializeField] private Material _deactivatedMaterial;
    [SerializeField] private Material _activatedMaterial;
    [SerializeField] private Transform _numberPlateParent;
    private NumberPlate[] _numberplates;

    private bool _isActive = false;
    private bool _canWin=false;
    private void OnEnable()
    {
        _numberplates= _numberPlateParent.GetComponentsInChildren<NumberPlate>();
        deactivateBtn();
    }
    public void activateBtn()
    {
        _isActive = true;

        _btnColor.material = _activatedMaterial;
    }

    public void deactivateBtn()
    {
        _isActive = false;

        _btnColor.material = _deactivatedMaterial;
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        _canWin=checkWin();
        if(_canWin ==true)
        {
            activateBtn();
        }

    }
    private bool checkWin()
    {
        for (int i = 0; i < _numberplates.Length; i++)
        {

            if (_numberplates[i].isActive)
            {
                return false;
            }
        }
        return true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("face") && _isActive)
        {
            Debug.Log("Player Touched the Win BTN");
        }
    }
}
