using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomspawnsprite : MonoBehaviour
{
    public float Min;
    public float Max;

    void Start()
    {
        Vector3 pos;
        pos = transform.position;

        pos.x += Random.Range(Min,Max);

        transform.position = pos;
    }
}
