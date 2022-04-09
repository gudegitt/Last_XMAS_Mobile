using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedog : MonoBehaviour
{
    public float speed = 10f;


    SpriteRenderer dg;


    void Start()
    {
        //speed = 10f;
        dg = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime, 0f, 0f, Space.World);
        if (!wood_throw.lose) {
            if (transform.position.x < -6.62f)
            {
                speed = -speed;
                dg.flipX = false; ;
            }
            if (transform.position.x > 5.46f)
            {
                speed = -speed;
                dg.flipX = true;
            }
        }
        else {
            if (transform.position.x < -6.62f)
            {
                speed = 0;
                dg.flipX = false; ;
            }
            if (transform.position.x > 5.46f)
            {
                speed = 0;
                dg.flipX = true;
            }
        }
    } 
}
