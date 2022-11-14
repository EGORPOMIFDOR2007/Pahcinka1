using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tractorbodymovement : MonoBehaviour
{
    public float SpeedX;
    

    void Update()
    {
        transform.Translate(SpeedX, 0f, 0f);
    }
}
