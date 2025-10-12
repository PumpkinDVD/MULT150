using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      for(int February = 1; February <=29; February++)
        {
            if (February == 29)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(February);
            }
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
