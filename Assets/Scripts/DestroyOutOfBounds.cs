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
