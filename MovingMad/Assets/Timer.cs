using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text CounterTimer;
    public int framecounter = 0;
    public int counter = 0;
    void Start()
    {
        CounterTimer.text = "among ";
    }
 

    // Update is called once per frame

    public void Update()
    {
        framecounter = framecounter + 1;
  
        if (framecounter >= 60)
        {
            counter++;
            framecounter = 0;
        }
      
        CounterTimer.text = counter.ToString();
    }
}
