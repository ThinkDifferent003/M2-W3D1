using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    [SerializeField] int[] arraybase;
    [SerializeField] int dimension;
    // Start is called before the first frame update
    void Start()
    {
        int[] primoarray = CambiaDimensioneArray(arraybase , dimension);
        Debug.Log("Nuova dimensione array = " + primoarray.Length);

    

    }
    int []CambiaDimensioneArray (int[] array, int dim)
    {
         if (dim == array.Length)
            {
                Debug.Log("Array uguale");
                return array;
            }

         else if (dim < array.Length)
            {
                int[] newarray = new int[dim];
                for (int i = 0; i < dim; i ++)
                {
                    newarray[i] = array[i];
                Debug.Log("Array diminuito");
                }
              
                return newarray;
            }
         else 
            {
                int[] secondarray = new int[dim];
                for (int i = 0; i< array.Length; i ++)
                {
                    secondarray[i] = array[i];
                Debug.Log("Array aumentato");
                }
                return secondarray;
            }
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
