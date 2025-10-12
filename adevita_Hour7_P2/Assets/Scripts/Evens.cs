using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float evens = 22f;
        float two = 2f;
        Debug.Log(evens);
        while(evens < 100)
        {
            evens += two;
            Debug.Log(evens);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
