using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Light Lightbulb;
    void Start()
    {
        Lightbulb = GetComponent<Light>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L) && Lightbulb.intensity == 0f)
        {
            Lightbulb.intensity = 2f;
        }
            
        else if (Input.GetKey(KeyCode.L))
            Lightbulb.intensity = 0f;
    }
}
