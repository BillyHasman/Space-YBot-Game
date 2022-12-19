using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenDoorAccess : MonoBehaviour
{

    public GameObject lightAccess;
    public Color green;

    public void greenDoor()
    {
        lightAccess.GetComponent<Light>().color = green;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
