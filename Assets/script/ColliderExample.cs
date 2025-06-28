using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderExample : MonoBehaviour
{
    public BoxCollider myBoxCollider;
    void Start()
    {
        myBoxCollider.isTrigger = false;
    }
}
