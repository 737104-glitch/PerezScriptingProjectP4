using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this is line is here to tell the x position of the objecct


        Debug.Log(transform.position.x);   
    }

    // Update is called once per frame
    void Update()
    {
     if (transform.position.y<=5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
