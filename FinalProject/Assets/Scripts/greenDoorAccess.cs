using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class greenDoorAccess : MonoBehaviour
{

    public GameObject lightAccess;
    public BoxCollider topTrigger;
    public BoxCollider bottomTrigger;
    public Color green;
    public Color red;

    // public Button ButtonUnlockDoor;

    public void greenDoor()
    {
        if (DoorControllerOxygen.isDoorActive == false)
        {
            DoorControllerOxygen.isDoorActive = true;
            topTrigger.GetComponent<BoxCollider>().enabled = true;
            bottomTrigger.GetComponent<BoxCollider>().enabled = true;
            lightAccess.GetComponent<Light>().color = green;
        }
        else
        {
            lightAccess.GetComponent<Light>().color = red;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        topTrigger.GetComponent<BoxCollider>().enabled = false;
        bottomTrigger.GetComponent<BoxCollider>().enabled = false;
    }


    // Update is called once per frame
    void Update()
    {

    }
}
