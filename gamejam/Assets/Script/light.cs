﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public float speed = 1.0f;
    public int wasd;
    public int start;


    //포탈 관련 변수
    public static char key_down;
    public GameObject potalA;
    public GameObject potalB;
    //


    // Start is called before the first frame update
    void Start()
    {
        wasd = 0;
        if (Player.key_down == 'D')
        {
            start = 0;
        }
        else if (Player.key_down == 'A')
        {
            start = 1;
        }
        else if (Player.key_down == '1')
        {
            wasd = 2;
        }
        else if (Player.key_down == '2')
        {
            wasd = 1;
        }
        else if (Player.key_down == '3')
        {
            wasd = 8;
        }
        else if (Player.key_down == '4')
        {
            wasd = 3;
        }
        else if (Player.key_down == '5')
        {
            wasd = 6;
        }
        else if (Player.key_down == '6')
        {
            wasd = 7;
        }
        else if (Player.key_down == '7')
        {
            wasd = 4;
        }
        else if (Player.key_down == '8') {
            wasd = 5;
        }
        else if (Player.key_down == '9')
        {
            wasd = 6;
        }
        Debug.Log(wasd);
    }

    // Update is called once per frame
    void Update()
    {
        if (wasd == 0)
        {
            if (start == 0)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                wasd = 7;
            }
            else if (start == 1)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                wasd = 3;
            }
        }
        else if (wasd == 5)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if (wasd == 7)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (wasd == 1)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        else if (wasd == 3)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (wasd == 6) {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if (wasd == 4)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.position += Vector3.up * speed * Time.deltaTime;

        }
        else if (wasd == 2)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        else if (wasd == 8)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.position += Vector3.down * speed * Time.deltaTime;

        }
    }
    void OnTriggerEnter2D(Collider2D col) {
        // 거울 위 오른
        if (col.gameObject.tag.Equals("812R456"))
        {
            if (wasd == 8)
            {
                wasd = 6;
            }
            else if (wasd == 1)
            {
                wasd = 5;
            }
            else if (wasd == 2)
            {
                wasd = 4;
            }
            else if (wasd == 4)
            {
                wasd = 2;
            }
            else if (wasd == 5)
            {
                wasd = 1;
            }
            else if (wasd == 6)
            {
                wasd = 8;
            }
        }
        //거울 오른 아래
        if (col.gameObject.tag.Equals("123R567"))
        {
            if (wasd == 1)
            {
                wasd = 7;
            }
            else if (wasd == 2)
            {
                wasd = 6;
            }
            else if (wasd == 3)
            {
                wasd = 5;
            }
            else if (wasd == 5)
            {
                wasd =3;
            }
            else if (wasd == 6)
            {
                wasd = 2;
            }
            else if (wasd == 7)
            {
                wasd = 1;
            }
        }
        //거울 아래 왼
        if (col.gameObject.tag.Equals("234R678"))
        {
            if (wasd == 2)
            {
                wasd = 8;
            }
            else if (wasd == 3)
            {
                wasd = 7;
            }
            else if (wasd == 4)
            {
                wasd = 6;
            }
            else if (wasd == 6)
            {
                wasd = 4;
            }
            else if (wasd == 7)
            {
                wasd = 3;
            }
            else if (wasd == 8)
            {
                wasd = 2;
            }
        }
        //거울 왼 위
        if (col.gameObject.tag.Equals("345R781"))
        {
            if (wasd == 3)
            {
                wasd = 1;
            }
            else if (wasd == 4)
            {
                wasd = 8;
            }
            else if (wasd == 5)
            {
                wasd = 7;
            }
            else if (wasd == 7)
            {
                wasd = 5;
            }
            else if (wasd == 8)
            {
                wasd = 4;
            }
            else if (wasd == 1)
            {
                wasd = 3;
            }
        }
        /////포탈 충돌관련 함수
        for (int i = 0; i < 10; i++)
        {
            if (col.gameObject.tag.Equals("potalA" + i))
            {
     
                potalB = GameObject.FindWithTag("potalB" + i);
               if (Player.key_down == 'A')
               {
                    transform.position = new Vector2((10 * potalB.transform.position.x - 7) / 10, potalB.transform.position.y);
               }
               else if (Player.key_down == 'D')
               {
                  Debug.Log("asdfasdfasdf");
                  transform.position = new Vector2((10 * potalB.transform.position.x + 7) / 10, potalB.transform.position.y);
               }

            }

        }

        for (int i = 0; i < 10; i++)
        {
            if (col.gameObject.tag.Equals("potalB" + i))
            {
                potalA = GameObject.FindWithTag("potalA" + i);
                if (Player.key_down == 'A')
                {
                   transform.position = new Vector2((10 * potalA.transform.position.x - 7) / 10, potalA.transform.position.y);
                }
                else if (Player.key_down == 'D')
                {
                   transform.position = new Vector2((10 * potalA.transform.position.x + 7) / 10, potalA.transform.position.y);
                }

            }
        }
        ///////////////////////////////////////
    }

}
