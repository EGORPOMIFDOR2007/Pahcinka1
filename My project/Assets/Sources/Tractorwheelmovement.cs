using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tractorwheelmovement : MonoBehaviour
{
    public float SpeedZ;

    void Update()
    {
        transform.Rotate(0f, 0f, SpeedZ);
        
    }
}
