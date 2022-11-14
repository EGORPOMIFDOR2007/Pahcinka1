using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rabbittime_anim : MonoBehaviour
{
    public RabbitState State;
    public float TimePassed;
    public float CD1;
    public float CD2;
    public float Speed1;
    public float Speed2;

 public enum RabbitState
    {
        MovingToCarrot,
        Waiting,
        Run,
    }
    void Update()
    {
        switch (State)
        {
            case RabbitState.MovingToCarrot:
                transform.Translate(Speed1 * Time.deltaTime, 0f, 0f);
                GetComponent<Animator>().SetFloat("RunSpeed", Speed1);
                break;

            case RabbitState.Waiting:
                TimePassed += Time.deltaTime;
                if (TimePassed > CD2)
                {
                    GetComponent<Animator>().Play("RabbitAnimation");
                    State = RabbitState.Run;
                    TimePassed = 0f;
                }
                break;
            case RabbitState.Run:
                transform.Translate(Speed2 * Time.deltaTime, 0f, 0f);
                GetComponent<Animator>().SetFloat("RunSpeed", Speed2);
                break;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Animator>().Play("RabbitAnimation_stop");
        State = RabbitState.Waiting;
        TimePassed = 0f;
    }

}

