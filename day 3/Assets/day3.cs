using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{
    string heroName = "hulk";
    int heroPower = 40;
    string  villianName = "red hulk";
    int villianPower = 20;
    float playerSpeed = 2.4f;


    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villianPower)
        {
            print("hero is stronger than villian");

        }
        else if (heroPower < villianPower)
        {
            print("villian is stronger than hero");
        }
        else
        {
            print("villain and hero have the same strength");

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setSpeed (float newSpeed)
    {
        print("old speed is " + playerSpeed);
        playerSpeed = newSpeed;
        print("new speed is " + playerSpeed);

    }
    
}
