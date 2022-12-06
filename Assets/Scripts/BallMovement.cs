using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : ZumaView
{
    public Transform[] points;
    private int index =1;
    
   

    // Start is called before the first frame update
    void Start()
    {
      
       
        transform.position = points[0].position; // set starting position for movement
       
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }
    new public void MoveBall()
    {
        if (index < points.Length) 
        {
            transform.position = Vector2.MoveTowards(transform.position, points[index].position, 2 * Time.deltaTime); // move from one point to 2nd point to follow the line on screen
        }
        if (transform.position == points[index].transform.position && index < points.Length - 1)
        {
            index++; // increase index so next point can be accessed
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        if(gameObject.tag == collision.gameObject.tag) // if both balls are of same color  destroy both balls and increase score by 1
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            score++;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject); // on entering black hole destroy ball
    }


}
