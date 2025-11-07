using UnityEngine;
public class VeslowcityScript : MonoBehaviour
{
    public float startSpeed = 10f;
    void Start()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector3(startSpeed, 0, startSpeed);
    }

}