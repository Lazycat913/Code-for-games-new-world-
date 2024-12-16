using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutaction : MonoBehaviour
{

   public Animator llama;
      public GameObject asdfgh;


    // Start is called before the first frame update
    void Start()
    {
        
    }
       // this makes it so to where the animatiion activates when the player gets into set zone//
         void OnTriggerEnter (Collider other){
          if (other.tag=="Player"){
           Debug.Log("something");
           asdfgh.SetActive(true);
           llama.Play("greeting");
          }
         }
    // Update is called once per frame
    void Update()
    {
        
    }
}
