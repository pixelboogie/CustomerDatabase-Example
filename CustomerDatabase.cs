using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    
    public Customer cust1;
    public Customer cust2;
    public Customer cust3;

    public Customer[] customers;

    void Start()
    {
        cust1 = new Customer("Jonathon", 10);
        cust2 = new Customer("Jannet", 11);
        cust3 = new Customer("Joe", 12);
    }

    
    void Update()
    {
        
    }
}
