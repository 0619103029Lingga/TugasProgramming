using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public float xRange = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //keep the player in bounds 
        if (transform.position.x < xRange)
        {
            transform.position = new Vector3( xRange, transform.position.y, transform.position.z); 
        }
            if (transform.position.x > xRange)
         {
             transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
