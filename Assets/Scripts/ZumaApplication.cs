using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZumaApplication : MonoBehaviour
{
    public ZumaController controller;
    public ZumaView View;
    public TextMeshProUGUI scoreText;
    private float timeApp = 0;
    public static bool gameOver =false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeApp += Time.deltaTime;
        scoreText.text = "Score: " + ZumaView.score; //display score on screen
        int size = FindObjectsOfType<BallMovement>().Length; // checks for how many spawned balls are in game
        if(size==0 && timeApp>1) // if no spawned ball is in game and time is more than 1 so it doesnt makes the gameover before balls are spawned
        {
            gameOver=true; //set game over true;
           
        }
    }
}
