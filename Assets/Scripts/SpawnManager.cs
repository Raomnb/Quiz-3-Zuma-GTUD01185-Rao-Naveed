using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : ZumaController
{
    public GameObject[] ballPrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBalls());
    }

    // Update is called once per frame
    void Update()
    {

        if (balls.Count == 20)
        {
            StopAllCoroutines();
        }
        
          

    }
    IEnumerator SpawnBalls()
    {
        while (balls.Count < 20)
        {
            yield return new WaitForSeconds(0.4f); // give a delay of 0.4 seconds
            int index = Random.Range(0, ballPrefab.Length); //get random color ball
            balls.Add(Instantiate(ballPrefab[index], new Vector2(8.54f, 4.09f), ballPrefab[index].transform.rotation)); //spawn random ball at start of line to follow
            
            
        }
        

    }
   

}

