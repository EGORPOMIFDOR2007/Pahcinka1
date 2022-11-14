using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomspawnhero : MonoBehaviour
{
    
    void Start()
    {
        Vector3 pos;
        pos = transform.position;

        pos.x += Random.Range(-2.5f,3.5f);
         
        transform.position = pos;

    }

}
