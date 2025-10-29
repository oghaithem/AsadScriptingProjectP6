using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class varieblesandfunctions : MonoBehaviour
{
    //create an integer variable
    int myint = 5;
    // Start is called before the first frame update
    void Start()
    {
        //run  the variable through my function 
        myint = MultiplyByTwo(myint);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //creating my function
    int MultiplyByTwo(int number)
    {
        //create a resultss variable
        int result;
        result = number * 2;

        //return the result
        return result;


    }

}
