using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Customer
{

    public string firstName;
    public int age;

    public Customer(string fn, int a)
    {

        this.firstName = fn;
        this.age = a;

        Debug.Log("Customer ---> " + firstName + " age " + age);
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
