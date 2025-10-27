using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int healthpoints = 3992;
    void Start()
    {
        Debug.Log("Hour 8 stumped me. Game over");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}
