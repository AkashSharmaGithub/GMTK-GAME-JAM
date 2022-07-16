using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueCalculation :MonoBehaviour
{
    public int getOppositeFacingNumber(int num)
    {
        switch (num)
        {
            case 1:
                return 6;
                break;
            case 2:
                return 5;
                break;

            case 3:
                return 4;
                break;

            case 4:
                return 3;
                break;

            case 5:
                return 2;
                break;
            case 6:
                return 1;
                break;


        }
        return -1;
    }
    public NumberPlate getOppositeNumberBox(int value,NumberPlate[] numberPlates)
    {
        int oppositeSideNumber = getOppositeFacingNumber(value);
        for (int i = 0; i < oppositeSideNumber; i++)
        {
            if (numberPlates[i].number == oppositeSideNumber)
            {
                return numberPlates[i];
            }
        }
        return null;
    }

    public Face getOppositeFacingFace(Face.facing facingToward,Dictionary<Face.facing,Face> FacesWithFacingTowards)
    {
        switch (facingToward)
        {
            case Face.facing.up:
                return FacesWithFacingTowards[Face.facing.down];
                break;
            case Face.facing.down:
                return FacesWithFacingTowards[Face.facing.up];
                break;

            case Face.facing.left:
                return FacesWithFacingTowards[Face.facing.right];
                break;

            case Face.facing.right:
                return FacesWithFacingTowards[Face.facing.left];
                break;

            case Face.facing.front:
                return FacesWithFacingTowards[Face.facing.back];
                break;
            case Face.facing.back:
                return FacesWithFacingTowards[Face.facing.front];
                break;


        }
        return null;
    }

    public void setoppsiteFacingFaceValue(Face.facing facingTowards, int value,Dictionary<Face.facing,Face> faceAsValueAndFaceFacingAsKey)
    {
        Face temp =getOppositeFacingFace(facingTowards, faceAsValueAndFaceFacingAsKey);
        temp.setvalue(getOppositeFacingNumber(value));
    }
}
