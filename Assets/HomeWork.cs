using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HomeWork : MonoBehaviour
{
    [SerializeField]
    private int arrayLenght;
    [SerializeField]
    private int rangeFrom = -100;
    [SerializeField]
    private int rangeTo = 101;
    void Start()
    {

        int[] arrayToSort = CreateArray(arrayLenght);
        PrintArray(arrayToSort);
        Debug.Log("Array before sort ^ Array after sort v");
        DateTime startTime = DateTime.Now;
        SelectionSort(arrayToSort);
        PrintArray(arrayToSort);
        DateTime endTime = DateTime.Now;
        Debug.Log($"Sorted in {(endTime - startTime).TotalSeconds} seconds");
    }

    private int[] CreateArray(int arrayLenght)
    {
        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = UnityEngine.Random.Range(rangeFrom, rangeTo);
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
    private void SelectionSort(int[] arrayToSort)
    {
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
    }
}
