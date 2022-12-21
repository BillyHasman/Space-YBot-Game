using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOxygen : MonoBehaviour
{
    public Slider OxygenBar;
    public int Oxygen;

    // private bool stopTimer;

     public void UpdateOxygen(int NewOxygen)
    {
        Oxygen = NewOxygen;
    }

    void Start()
    {
        // stopTimer = false;
        OxygenBar.maxValue = 100;
        // OxygenBar.value = Oxygen;
        StartCoroutine("OxygenCalculation");
    }

    IEnumerator OxygenCalculation()
    {
        for(;;) {
            yield return new WaitForSeconds(5f);
            Oxygen -=1;
         
        }
    }

    void Update()
    {   
        OxygenBar.value = Oxygen;


        // float time = Oxygen - Time.time;

        // int minutes = Mathf.FloorToInt(time / 60);
        // int seconds = Mathf.FloorToInt(time - minutes * 60f);

        // if (time <= 0)
        // {
        //      stopTimer = false;   
        // }

        // if (stopTimer == false)
        // {
        //     OxygenBar.value = time;
        // }
    }
}
