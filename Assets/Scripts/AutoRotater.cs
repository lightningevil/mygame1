using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotater : MonoBehaviour
{
    int width,heigth,result;
    void Start()
    {
        int width = 10;
        int height = 5;
        int result = width*height;
        print(result);

        int money = 50;
        if (money >= 100)
        {
            print("ok this is your Toy");
        }
        else if (money >= 50 && money < 100)
        {
            print("ok this is your Gunpla");
        }
        else if (money >= 20 && money < 50)
        {
            print("ok this is your Game");
        }
        else
        print("you will got nothing");
    }
}
