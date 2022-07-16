using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[ExecuteInEditMode]
public class NumberPlate : MonoBehaviour
{
    [SerializeField] private TextMeshPro _text;
    // Start is called before the first frame update
    [SerializeField] private int _number;
    public int number { get { return _number; } }
    
    private void OnEnable()
    {
       _text.text=number.ToString();
        
    }

   
    private void Update()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            _text.text = number.ToString();
           
        }
        
    }
}
