using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvas : MonoBehaviour
{
    private Canvas c;

    void Start()
    {
        c= GetComponent<Canvas>();
    }

    void Update ()
    {
   		if (Input.GetKeyUp (KeyCode.Escape))
           {                
               c.enabled= !c.enabled;
           }
           
    }
}
           