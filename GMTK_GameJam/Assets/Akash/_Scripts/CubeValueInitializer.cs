using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeValueInitializer:MonoBehaviour 
{
    public Dictionary<Face.facing, Face> FacesWithFacingTowardAsKey { get; private set; } = new Dictionary<Face.facing, Face>();
   public Face[] faces { get; private set; }

    public NumberPlate[] numberPlates { get; private set; }


    
    public  CubeValueInitializer(Transform numberPlateParent)
    {
        faces = CubeManager.Instance.GetComponentsInChildren<Face>();
        getNumberPlates(numberPlateParent);
        initialiseNumberPlate();
        addFaceAsValueAndFacingTowardsAsKeyToDictionary(faces);
        
        
        setInitialCubeFaceValues(faces);
        setNumberForOppsiteFacesWithNumbers();
        
        
        addNumberPlatesToFacesWithNumberDuringStartOfGame();
    }

    public void getNumberPlates(Transform parent)
    {
        numberPlates=parent.GetComponentsInChildren<NumberPlate>();
    }
    public void addFaceAsValueAndFacingTowardsAsKeyToDictionary(Face[] faces)
    {
        for (int i = 0; i < faces.Length; i++)
        {
        
            FacesWithFacingTowardAsKey.Add(faces[i].facingToward, faces[i]);


        }
    }
    public void setInitialCubeFaceValues(Face[] faces)
    {
        for (int i = 0; i < faces.Length; i++)
        {
            faces[i].setInitialValues();
        }
    }
    public void initialiseNumberPlate()
    {
        for (int i = 0; i < numberPlates.Length; i++)
        {
            numberPlates[i].activateBtn();



        }
    }
    private void addNumberPlatesToFacesWithNumberDuringStartOfGame()
    {
        for (int i = 0; i < faces.Length; i++)
        {
            Debug.Log("i=" + i);
            if (faces[i].number == -1)
            {
                continue;  
            }
                for (int j = 0; j < numberPlates.Length; j++)
                {
                Debug.Log("i=" + i+" j="+j);
                Debug.Log("number on the face =" + faces[i].number);
                Debug.Log("number on the numberplate =" + numberPlates[j].number);
                if (faces[i].number == numberPlates[j].number)
                    {
                        faces[i].setNumberPlate(numberPlates[j]);
                    }
                
                
                

            }

        }
    }
    private void setNumberForOppsiteFacesWithNumbers()
    {

        for (int i = 0; i < faces.Length; i++)
        {
            if (faces[i].number != -1)
            {
               CubeManager.Instance.finder.setoppsiteFacingFaceValue(faces[i].facingToward, faces[i].number,FacesWithFacingTowardAsKey);

            }

        }


    }
}
