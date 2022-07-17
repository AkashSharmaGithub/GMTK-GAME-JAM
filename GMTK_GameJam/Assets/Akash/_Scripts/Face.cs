using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Face : MonoBehaviour
{
    
    public enum facing
    {
        up,down,left,right,front,back
    }
    [SerializeField]private TextMeshPro _text;
    [SerializeField]
    private facing _facingToward;
    [SerializeField]
    private NumberPlate _numberplate;


    public TextMeshPro text
    {
        get { return _text; }
    }
    public facing facingToward
    {
        get { return _facingToward;}
    }
   public NumberPlate numberplate
    {
        get { return _numberplate; }
    }
    public int number { get; private set; } =-1;

    
    public void setInitialValues()
    {
        number=int.Parse(text.text);
        if (number != -1)
        {
            _text.text = number.ToString();
            _text.gameObject.SetActive(true);
        }
        else
        {
            number = -1;
            _text.gameObject.SetActive(false);
        }
    }
    public void setvalue(int value)
    {
       
            number = value;
        _text.text = number.ToString();
        _text.gameObject.SetActive(true);

        //update opposite facing face value with 

    }
    public void setNumberPlate(NumberPlate plate)
    {
        this._numberplate = plate;
        number = _numberplate.number;
        _text.text = number.ToString();
        _text.gameObject.SetActive(true);
        this._numberplate.deactivateBtn();
    }

}
