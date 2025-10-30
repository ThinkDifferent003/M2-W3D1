using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int  i = 0; i <= 10; i++)
        {
            Debug.Log("tabellina del " +  i);
            for(int j = 0; j <= 10; j++)
            {
                Debug.Log(i + "x" + j + "=" + (i * j));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
