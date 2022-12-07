using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShoot : ZumaView
{
    public GameObject[] ballsPrefab;
    private GameObject ballInstance = null;
    Vector3 mousePos;
    public Camera cam;
    private Rigidbody2D rb;
    int index;
    float time1 = 0;
    // Start is called before the first frame update
    void Start()
    {

        
    }
   
    // Update is called once per frame
    void Update()
    {
        time1 += Time.deltaTime;
        if(time1>0.5f && !ZumaApplication.gameOver)
        {
            SpawnBall(); // if game is not over spawnBall
            
        }
        if (Input.GetMouseButtonDown(0) && time1 > 0.5f && !ZumaApplication.gameOver)
        {
            MoveBall(); // on mouse click call moveball function 
            if(tries>0)
            {
                tries--; // reduce shoots remaining by 1
            }
            else
            {
                ZumaApplication.gameOver = true; // if shoots remaining are 0 set gameover bool true
               
            }
            time1 = 0;
        }

    }
   new  public void MoveBall()
    {
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f)); //get current move position
            
        rb.AddForce(Vector2.MoveTowards(transform.position,mousePos,10) * 10, ForceMode2D.Impulse); // add force in direction of mouse position
        StartCoroutine(Destroy()); //destroy spawned ball after 2 seconds
      //  ballInstance = null; //set ball instance null so new ball can be spawned

       
    }
    private void SpawnBall()
    {
        if (ballInstance == null) // if ball instance is null meaning ball is shot then instantiate new random ball
        {
            StopAllCoroutines();
            index = Random.Range(0, ballsPrefab.Length); // get random index
            ballInstance = Instantiate(ballsPrefab[index], new Vector2(0f, -1.5f), ballsPrefab[index].transform.rotation); //spawn random color ball
            rb = ballInstance.gameObject.GetComponent<Rigidbody2D>(); //set rb as rigid body of spawned ball
            rb.gravityScale = 0;  // set gravity 0
           
        }
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(ballInstance.gameObject);
    }
    

}
