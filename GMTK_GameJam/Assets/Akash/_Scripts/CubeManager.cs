using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private CubeValueInitializer initializer;
    private CollisionHandler collisionHandler;
    private Transform numberPlateParent;
    public ValueCalculation finder { get; private set; }
    public static CubeManager Instance { get; private set;}
   
    
    
    
    private void Awake()
    {
        Instance = this;
        finder = new ValueCalculation();
        numberPlateParent = GameObject.FindGameObjectWithTag("numberPlateHolder").transform;
        initializer=new CubeValueInitializer(numberPlateParent:numberPlateParent);
        collisionHandler=new CollisionHandler(initializer,finder);
    }
   
    private void OnEnable()
    {
        collisionHandler.subscribeToCollisionAction();
          
     
      
        
    }
    private void OnDisable()
    {
       collisionHandler.unSuscribeToCollisionAction();
        
    }
   
   

    
  
  
 
}
