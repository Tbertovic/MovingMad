﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Component")]
    public Text timer;
    public int framecounter = 0;
    public int counter = 0;
    public int timeScore;
    void Start()
    {
    }
 

    // Update is called once per frame

    public void Update()
    {
        framecounter = framecounter + 1;
  
        if (framecounter >= 360)
        {
            counter++;
            framecounter = 0;
        }
      
        timer.text = counter.ToString();
        timeScore = int.Parse(timer.text);
    }
}
