using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
   public GameObject Light;
   
   private void Start() {
        Light.SetActive(false);
   }
   void OnTriggerStay(Collider other){
            if(Input.GetKeyDown(KeyCode.E)){
            Light.SetActive(true);
        }
    }
}
