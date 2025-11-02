using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript_ : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " entered " + gameObject.name);
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is in " + gameObject.name);
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " left " + gameObject.name);
    }
}