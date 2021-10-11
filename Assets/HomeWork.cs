using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork : MonoBehaviour
{
    [SerializeField]
    private int arrayLenght;
    void Start()
    {
        int[] arrayToSort = CreateArray(arrayLenght);
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            int minimumNumberIndex = i;
            for (int j = i; j < arrayToSort.Length; j++)
            {
                if (arrayToSort[minimumNumberIndex] > arrayToSort[j])
                {
                    minimumNumberIndex = j;
                }
            }

            int temp = arrayToSort[i];
            arrayToSort[i] = arrayToSort[minimumNumberIndex];
            arrayToSort[minimumNumberIndex] = temp;
        }
        PrintArray(arrayToSort);
    }

    private int[] CreateArray(int arrayLenght)
    {
        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = Random.Range(-10, 11);
        }
        return array;
    }
    private void PrintArray(int[] arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.Length; i++)
        {
            Debug.Log(arrayToPrint[i]);
        }
    }
}
