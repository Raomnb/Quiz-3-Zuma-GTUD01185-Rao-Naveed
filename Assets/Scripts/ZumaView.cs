using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZumaView : ZumaApplication
{
    public static int score = 0;
    private float time = 0;
    private int timer = 0;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI triesText;
    public TextMeshProUGUI GameOverText;
    public static int  tries = 20;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            time += Time.deltaTime; // runs timer
            timer = (int)time; // convert time to seconds
            timerText.text = "Time: " + timer + " Seconds"; // display time in seconds on screen
        }
        triesText.text = "Shoots Remaining: "+ tries; // display shoots remaining on screen
        if(ZumaView.gameOver)
        {
            GameOverText.text = "Game Over !"; //if game over shows gameover on screen
        }
        
    }
    public void MoveBall()
    {

    }
}
