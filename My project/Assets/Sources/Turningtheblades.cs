using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turningtheblades : MonoBehaviour
{

    public float SpeedZ;
    
    void Update()
    {
        transform.Rotate(0f, 0f, SpeedZ);
    }
}
