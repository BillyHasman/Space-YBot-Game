using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControllerOxygen : MonoBehaviour
{
    public static bool isDoorActive = false;
    private void OnTriggerEnter(Collider other)
    {
        if (isDoorActive == false)
        {
            Debug.Log("Need Access");

        }
        else
        {
            if (other.tag == "GreenDoor")
            {
                Animator anim = other.GetComponentInChildren<Animator>();
                if (Input.GetKeyDown(KeyCode.E))
                {
                    anim.SetTrigger("OpenClose");
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "GreenDoor")
        {

        }
    }
}
