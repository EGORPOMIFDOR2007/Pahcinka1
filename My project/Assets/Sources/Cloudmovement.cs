using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudmovement : MonoBehaviour
{
   
    public float Speed;
    public float MaxX;
    public float LeftX;


    void Update()
    {
        
        transform.Translate(Speed, 0f, 0f);

        if (transform.position.x > MaxX)
        {
            transform.Translate(LeftX, 0f, 0f);
        }

    }
}
    