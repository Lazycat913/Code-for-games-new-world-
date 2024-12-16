using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
      
    // Update is called once per frame
    void Update()
    {     
        // this pretty much stops the game , though it lacks a menu//
         if (Input.GetKeyDown("p"))
         {
           if (Time.timeScale == 1.0f){
                Time.timeScale = 0f;
           }
                else{
                Time.timeScale = 1.0f;
                }

        


         }






    }
}
