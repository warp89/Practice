using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Callenge : MonoBehaviour
{
    [SerializeField]
    private int numberToCheck;
    void Start()
    {
        Debug.Log("First");
        for (int i = 1; i < 6;i++)
        {
            Debug.Log(i);
        }
        Debug.Log("Second");
        for (int i = 7; i > 1; i--)
        {
            Debug.Log(i);
        }
        Debug.Log("Third");
        Debug.Log($"Number {numberToCheck} is {SimpleNumberProofer(numberToCheck)}");
        
    }
    private string SimpleNumberProofer(int number)
    {
        if (number>1)
        {
            int i = 2;
            while (i!=number)
            {
                if (number%i==0)
                {
                    return "not simple";
                }
                i++;
            }
            return "simple";
        }
        return "not simple";
    }
    
}
