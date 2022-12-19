using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class DoorController : MonoBehaviour
    {
        Animator doorAnimator;
   
    private void OnTriggerStay(Collider other) {
         if(Input.GetKey(KeyCode.E)){
            doorAnimator.SetBool("DoorOpen", true);
        }
    }
    private void OnTriggerExit(Collider other) {
        doorAnimator.SetBool("DoorOpen", false);

    }
    
    private void Awake() {
        doorAnimator = this.transform.parent.GetComponent<Animator>();    
    }
}


