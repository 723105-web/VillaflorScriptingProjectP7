using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Creating an integer variable
    int myInt = 6;
    // Start is called before the first frame update
    void Start()
    {
        //running my int variable thru the function
        myInt = MultiplyByTwo(myInt);
            Debug.Log(myInt);
    }

    private int MultiplyByTwo(int myInt)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Creating a function to multiply a value by 2
    int multipyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
