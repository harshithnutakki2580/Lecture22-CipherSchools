
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
   int childCount = 0;

   [HideInInspector] public bool allCoinsCollected = false;
   [SerializeField] private int x;
   
   private void Start()
   {
    childCount = transform.childCount;
   }

   private void Update()
    {
        //Check if the count of child objects has changed
        if(transform.childCount < childCount)
        {
            Debug.Log("A child object has been destroyed");

            //Update the childcount variable
            childCount = transform.childCount;

            if(childCount == 0)
            {
                allCoinsCollected = true;
            }
        }
    }
   }
