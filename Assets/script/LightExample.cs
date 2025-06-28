using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightExample : MonoBehaviour
{
    public Light myLight;
    void Start()
    {
        myLight.color = Color.red;
        myLight.intensity = 0.1f;
        InvokeRepeating("lightColor", 0f, 0.15f);
    }

    void lightColor()
    {
        myLight.intensity += 0.2f;
        if(myLight.intensity >= 3)
        {
            CancelInvoke("lightColor");
        }
    }
}
