using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
      Animator doorAnimator;
   
    private void OnTriggerStay(Collider other) {
         if(Input.GetKey(KeyCode.E)){
            doorAnimator.SetBool("Switch", true);
        }
    }
    private void OnTriggerExit(Collider other) {
        doorAnimator.SetBool("Switch", false);

    }
    
    private void Awake() {
        doorAnimator = this.transform.parent.GetComponent<Animator>();    
    }
}
