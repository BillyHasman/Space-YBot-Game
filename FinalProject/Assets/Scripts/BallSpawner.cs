using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject objToSpawn;
    private GameObject Clone;

    void OnTriggerStay(){
         if(Input.GetKeyDown(KeyCode.E))
        {
            SpawnIt();
        }
    }

    void SpawnIt()
    {
        Clone = Instantiate(objToSpawn, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
    }
}
