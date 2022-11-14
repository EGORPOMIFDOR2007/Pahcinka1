using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float TimeStop;
    public float Coldawn;

    void Start()
    {
        TimeStop = 0f;
    }
    void Update()
    {
        TimeStop += Time.deltaTime;
        if (TimeStop > Coldawn)
        {
            Debug.Log("Stop");
            TimeStop -= Coldawn;
        }

    }
}
