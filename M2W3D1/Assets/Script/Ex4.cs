using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ex4 : MonoBehaviour
{
    [SerializeField] private int arrayA;
    [SerializeField] private int arrayB;
    [SerializeField] private int arrayC;
    // Start is called before the first frame update
    void Start()
    {
        int[] numeri = GeneraArray(arrayA, arrayB, arrayC);
        int basso = TrovaMinimo(numeri);
        int alto = TrovaMassimo(numeri);
        StampaArray(numeri);
        Debug.Log("Valore minimo: " + basso);
        Debug.Log("Valore massimo: " + alto);
        TrovaMinimi2(numeri);
        TrovaMassimi2(numeri);
    }

    int[] GeneraArray(int arraydimensione, int arrayminimo, int arraymassimo)
    {
        int[] array = new int[arraydimensione];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(arrayminimo, arraymassimo + 1);
        }
        return array;
    }
    void StampaArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Indice: " + i + " Valore: " + array[i]);
        }


    }

    int TrovaMinimo(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    void TrovaMinimi2(int[] array)
    {
        int min1;
        int min2;
        if (array[0] < array[1])
        {
            min1 = array[0];
            min2 = array[1];
        }
        else 
        {
            min1 = array[1];
            min2 = array[0];
        }
        for (int i = 0; i < array.Length; i++)
        {
            int n = array[i];
            if (n < min1)
            {
                min2 = min1;
                min1 = n;
            }
            else if (n < min2 && n!=min1)
            {
                min2 = n;
            }
        }
        Debug.Log("I numeri più piccoli sono " + min1 + " e" + min2);
    }

    int TrovaMassimo(int[] array)
    {
        int mass = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mass)
                mass = array[i];
        }
        return mass;
    }
    void TrovaMassimi2(int[] array)
    {
        int max1;
        int max2;
        if (array[0] > array[1])
        {
            max1 = array[0];
            max2 = array[1];
        }
        else
        {
            max1 = array[1];
            max2 = array[0];
        }
        for (int i = 0; i < array.Length; i++)
        {
            int n = array[i];
            if (n > max1)
            {
                max2 = max1;
                max1 = n;
            }
            else if (n > max2  && n!=max1)
            {
                max2 = n; 
            }
        }
        Debug.Log("I numeri più grandi sono " + max1 + " e" + max2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
