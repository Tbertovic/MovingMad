using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timer;
    public int framecounter = 0;
    public int counter = 0;
    public int timeScore;
    public Text scoredisplay;


    // Update is called once per frame

    public void Update()
    {
        framecounter = framecounter + 1;
  
        if (framecounter >= 60)
        {
            counter++;
            framecounter = 0;
        }
      
        timer.text = counter.ToString();
        timeScore = int.Parse(timer.text);

        int scoreint = 999999; // Write this into file so it saves
        if (scoreint > timeScore)
        {
            scoredisplay.text = "Score " + timeScore;
            scoreint = timeScore;
        }
        StreamWriter sw = new StreamWriter("highscore.txt");
        sw.WriteLine(scoreint);
        sw.Close();
    }
}
