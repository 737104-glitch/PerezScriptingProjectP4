using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{

    //create my integer variable
    public int myInt = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        //run my variable through my function
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //create my multiply by two function
    int MultiplyByTwo (int number)
    {
        //create local variable
        int result;

        //multiply the number by two
        result = number * 2;

        //return the value
        return result;
    }
}
