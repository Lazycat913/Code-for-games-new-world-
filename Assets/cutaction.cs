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
