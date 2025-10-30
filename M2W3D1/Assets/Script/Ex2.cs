using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    [SerializeField] private int n;
    [SerializeField] private int x;
    [SerializeField] private int y;
    // Start is called before the first frame update
    void Start()
    {
        if (IsEven(n)) 
        {
            Debug.Log("Il numero" + n +  "è pari");
        }
        else 
        {
            Debug.Log("Il numero N è dispari");
        }

        if (IsMultiple(x,y)) 
        {
            Debug.Log("Il numero" + y + "è multiplo del numero" + x);
        }
        else 
        {
            Debug.Log("Il numero" + y + "NON è multiplo del numero" + x);
        }
    }

    bool IsEven(int number) 
    {
        return number % 2 == 0;
    }

    bool IsMultiple(int baseNumber, int multiple) 
    {
        return multiple % baseNumber == 0;
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
