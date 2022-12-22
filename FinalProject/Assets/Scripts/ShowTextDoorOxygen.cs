using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTextDoorOxygen : MonoBehaviour
{
    public GameObject TextAccessDoorOxygen;
    public GameObject Eprompot;
    void Start()
    {
        TextAccessDoorOxygen.SetActive(false);
        Eprompot.SetActive(false);
    }

    void OnTriggerEnter()
    {
        if (DoorControllerOxygen.isDoorActive == false)
        {
            TextAccessDoorOxygen.SetActive(true);
            Eprompot.SetActive(false);
        }
        else
        {
            DoorControllerOxygen.isDoorActive = true;
            TextAccessDoorOxygen.SetActive(false);
            Eprompot.SetActive(true);

        }
    }

    void OnTriggerExit()
    {
        TextAccessDoorOxygen.SetActive(false);
        Eprompot.SetActive(false);
    }
}
