using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOxygen : MonoBehaviour
{
    public Slider OxygenBar;
    public float Oxygen;

    private bool stopTimer;

    void Start()
    {
        stopTimer = false;
        OxygenBar.maxValue = Oxygen;
        OxygenBar.value = Oxygen;
    }

    void Update()
    {
        float time = Oxygen - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        if (time <= 0)
        {
            stopTimer = true;
        }

        if (stopTimer == false)
        {
            OxygenBar.value = time;
        }
        
    }

}
