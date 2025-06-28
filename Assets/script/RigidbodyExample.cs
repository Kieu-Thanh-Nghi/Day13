using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyExample : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float speed = 3;
    void Update()
    {

        myRigidbody.velocity = Vector3.right * speed;
    }
}
