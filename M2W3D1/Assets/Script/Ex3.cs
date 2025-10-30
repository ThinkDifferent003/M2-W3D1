using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    [SerializeField] private int arraydimensione;
    [SerializeField] private int arrayminimo;
    [SerializeField] private int arraymassimo;
    // Start is called before the first frame update
    void Start()
    {
        int [] numeri = GeneraArray(arraydimensione , arrayminimo, arraymassimo);
        StampaArray(numeri);
        Debug.Log("Il minimo è" +  TrovaMinimo(numeri));
       
        Debug.Log("Il massimo è" + TrovaMassimo(numeri));   
  
    }

    int[] GeneraArray( int arraydimensione , int arrayminimo , int arraymassimo)
    {
        int[] array = new int[arraydimensione];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range (arrayminimo , arraymassimo);
        }
        return array;
    }
    void StampaArray(int[] array) 
    {
        for (int i = 0; i < array.Length;i++)
        {
            Debug.Log(i + array[i]);
        }
     
        
    }

    int TrovaMinimo(int[] array) 
    {
        int min = array[1];
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
        int mass = array [1];
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
