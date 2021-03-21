//Alex Schroder
//Program for dictating enemy movement
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float startz;
    public float starty;
    public float startx;
    public float endX;
    public float endy;
    public float endz;
    public float speed;

    void Update()
    {
        mover();
    }

    void mover()
    {
        this.transform.Translate(3f * Time.deltaTime * speed, 0f, 0f);

        if (this.transform.position.x >= endX || this.transform.position.x < startx)
        {
            speed = speed * -1;
        }


    }
}
