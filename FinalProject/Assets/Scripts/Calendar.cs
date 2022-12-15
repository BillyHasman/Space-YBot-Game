using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calendar : MonoBehaviour
{
    public Text calendarText;

    private void Awake()
    {
        calendarText = GetComponent<Text>();
    }

    private void Update()
    {
        DateTime time = DateTime.Now;
        string day = LeadingZero(time.Day);
        string month = time.ToString("MMMM");
        string year = LeadingZero(time.Year);
        

        calendarText.text = day + " " + month + " " + year; 
    }

    string LeadingZero (int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
