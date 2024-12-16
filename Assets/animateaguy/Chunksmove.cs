using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunksmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.W)){
         GetComponent<Animator>().SetBool("New Bool",true);
                     GetComponent<Animator>().SetBool("New Bool 0",false);

         }
        else if (Input.GetKey(KeyCode.A)){
         GetComponent<Animator>().SetBool("New Bool",false);

         GetComponent<Animator>().SetBool("New Bool 0",true);
         }
         else{
                     GetComponent<Animator>().SetBool("New Bool",false);
                     GetComponent<Animator>().SetBool("New Bool 0",false);

         }
    }
}
