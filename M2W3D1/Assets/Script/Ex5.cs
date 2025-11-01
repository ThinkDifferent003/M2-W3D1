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
       

    

    }
    int []CambiaDimensioneArray (int[] array, int dim)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (dim < array.Length)
            {
                int[] newarray = new int[dim];
                newarray[i] = array[dim - 1];
                Debug.Log("Array diminuito da : " + array.Length + ", a " + newarray.Length);
                return newarray;
            }
            else if (dim >  array.Length)
            {
                int[] secondarray = new int[dim];
                secondarray[i] = array[i];
                Debug.Log("Array aumentato da : " + array.Length + ", a " + secondarray.Length );
                return secondarray;
            }
            else if (dim == array.Length)
            {
                Debug.Log("Array uguale");
                return array;
            }
        }
        return array;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
