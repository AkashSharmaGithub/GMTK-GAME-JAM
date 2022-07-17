using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CollisionHandler : MonoBehaviour
{
    private CubeValueInitializer initializer;
    private ValueCalculation calculate;
    public CollisionHandler(CubeValueInitializer initializer,ValueCalculation calculate)
    {
        this.initializer = initializer;
        this.calculate = calculate;
    }
    public void subscribeToCollisionAction()
    {
        for (int i = 0; i < initializer.faces.Length; i++)
        {
            initializer.faces[i].gameObject.GetComponent<CollisionChecker>().OnCollisionWithNumberPlate += handleCollsion;



        }
    }
    public void unSuscribeToCollisionAction()
    {
        for (int i = 0; i < initializer.faces.Length; i++)
        {
            initializer.faces[i].gameObject.GetComponent<CollisionChecker>().OnCollisionWithNumberPlate -= handleCollsion;



        }
    }


    private void handleCollsion(Face face, NumberPlate numberPlate)
    {


        Face temp = face;
        Face opposite = calculate.getOppositeFacingFace(temp.facingToward, initializer.FacesWithFacingTowardAsKey);
        //temp.setvalue(num._number);
        if (temp.numberplate != null)
        {
            temp.numberplate.activateBtn();
            //temp.numberplate.gameObject.SetActive(true);
            opposite.numberplate.activateBtn();
           // opposite.numberplate.gameObject.SetActive(true);
            temp.setNumberPlate(numberPlate);
            //set the value of box 
            numberPlate = calculate.getOppositeNumberBox(temp.number, initializer.numberPlates);
            opposite.setNumberPlate(numberPlate);


        }
        else
        {

            temp.setNumberPlate(numberPlate);
            numberPlate = calculate.getOppositeNumberBox(temp.number, initializer.numberPlates);
            opposite.setNumberPlate(numberPlate);

        }
    }
}
