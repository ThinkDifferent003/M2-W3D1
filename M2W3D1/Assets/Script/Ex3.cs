using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    [SerializeField] private int arrayA;
    [SerializeField] private int arrayB;
    [SerializeField] private int arrayC;
    // Start is called before the first frame update
    void Start()
    {
        int[] numeri =  GeneraArray ( arrayA , arrayB , arrayC);
        int basso = TrovaMinimo(numeri);
        int alto = TrovaMassimo(numeri);
        StampaArray(numeri);
        Debug.Log("Valore minimo: " + basso);
        Debug.Log("Valore massimo: " + alto);
  
    }

    int [] GeneraArray( int arraydimensione , int arrayminimo ,  int arraymassimo)
    {
        int[] array = new int[arraydimensione];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range (arrayminimo , arraymassimo + 1);
        }
        return array;
    }
    void StampaArray(int[] array) 
    {
        for (int i = 0; i < array.Length;i++)
        {
            Debug.Log("Indice: " +i + " Valore: " + array[i]);
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

    int TrovaMassimo(int[] array)
    {
        int mass = array [0];
        for(int i = 0;i < array.Length;i++)
        {
            if(array[i] > mass) 
                mass = array[i];
        }
        return mass;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
