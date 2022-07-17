using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[ExecuteInEditMode]
public class NumberPlate : MonoBehaviour
{
    [SerializeField] private TextMeshPro _text;
    [SerializeField] private MeshRenderer _btnColor;
    // Start is called before the first frame update
    [SerializeField] private int _number;
    
    [SerializeField] private Material _deactivatedMaterial;
    [SerializeField] private Material _activatedMaterial;

    private bool _isActive = true;

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
    public bool isActive
    {
        get
        {
            return _isActive;
        }
       
    }
    public int number { get { return _number; } }
    
    private void OnEnable()
    {
       _text.text=number.ToString();
        activateBtn();
    }

   
    private void Update()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            _text.text = number.ToString();
           
        }
        
    }
}
