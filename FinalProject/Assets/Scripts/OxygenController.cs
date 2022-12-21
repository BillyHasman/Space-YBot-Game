 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenController : MonoBehaviour
{
    private PlayerOxygen playerOxygen;
    public int NewOxygen;

    public void Awake()
    {
        playerOxygen = GameObject.FindObjectOfType<PlayerOxygen>();

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "OxyButton")
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            if(Input.GetKeyDown(KeyCode.E)) {
                anim.SetTrigger("OpenClose"); 
                NewOxygen = 100;
                playerOxygen.UpdateOxygen(NewOxygen);
            }
         }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "OxyButton")
        {

        }
    }

    
}
