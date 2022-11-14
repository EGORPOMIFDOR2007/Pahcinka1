using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplanemovement : MonoBehaviour
{
   
    public float SpeedX;
    public float SpeedY;
    


    void Update()
    {
        transform.Translate(SpeedX , SpeedY , 0f);
    }
}