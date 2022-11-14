using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTime : MonoBehaviour
{
    public int State;
    public float TimePassed;
    public float CD1;
    public float CD2;
    public float Speed1;
    public float Speed2;
    void Update()
    {
        switch (State)
        {
            case 0:
                transform.Translate(Speed1 * Time.deltaTime, 0f, 0f);
                break;

            case 1:
                TimePassed += Time.deltaTime;
                if (TimePassed > CD2)
                {

                    GetComponent<SpriteRenderer>().flipX = true;
                    GetComponent<Animator>().Play("BirdAnimation");
                    State = 2;
                    TimePassed = 0f;
                }
                break;
            case 2:
                transform.Translate(Speed2 * Time.deltaTime, 0f, 0f);
                break;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Animator>().Play("BirdAnimationx");
        State = 1;
        TimePassed = 0f;
    }
}

