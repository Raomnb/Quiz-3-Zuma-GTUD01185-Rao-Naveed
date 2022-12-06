using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float timeDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeDestroy += Time.deltaTime;
        if(timeDestroy>2) //if ball after getting shot is not destroyed and is on game screen for 2 seconds destroy it after 2 seconds and also if no ball of same color is in game it changes its color after 2 seconds
        {
            Destroy(gameObject);
        }
        if(transform.position.y>5 || transform.position.y<-5) // if ball goes out of bound on y axis destroy it
        {
            Destroy(gameObject);

        }
        if(transform.position.x>10 || transform.position.x<-10) // if ball goes out of bounds on x axis destroy it
        {
            Destroy(gameObject);
        }
    }
}
