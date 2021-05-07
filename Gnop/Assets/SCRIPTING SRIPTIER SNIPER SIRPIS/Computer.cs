using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public float moveSpeed = 400f;
    public float topBounds = 24f;
    public float bottomBounds = -24f;
    public Vector2 starttingPosition = new Vector2(31f, 1.6f);
    private GameObject ball;
    private Vector2 ballPos;
    private GameObject[] ballsInPlay;

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = (Vector3)starttingPosition;
        ball = GameObject.FindGameObjectWithTag("ball");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        if (ball.GetComponent<Ball>().getRight() == false)
            findNewBall();
    }

    void Move()
    {
        //transform.localPosition.y > bottomBounds && 
        /*if (!ball)
            ball = GameObject.FindGameObjectWithTag("ball");*/
        if (ball.GetComponent<Ball>().getRight())
        {
            ballPos = ball.transform.localPosition;
            if (transform.localPosition.y > bottomBounds && ballPos.y < transform.localPosition.y)
            {
                transform.localPosition += new Vector3(0, -moveSpeed * Time.deltaTime, 0);
            }
            if (transform.localPosition.y < topBounds && ballPos.y > transform.localPosition.y)
            {
                transform.localPosition += new Vector3(0, moveSpeed * Time.deltaTime, 0);
            }
        }
    }
    private void findNewBall()
    {
        var list = new ArrayList(); 
        ballsInPlay = GameObject.FindGameObjectsWithTag("ball");
        for(int i = 0; i < ballsInPlay.Length; i++)
        {
            if (ballsInPlay[i].GetComponent<Ball>().getRight())
            {
                list.Add(ballsInPlay[i]);
            }
        }
        if (list.Count == 0)
        {
            float x = 27f;
            GameObject temp=null;
            for (int i = 0; i < ballsInPlay.Length; i++)
            {
                if (ballsInPlay[i].GetComponent<Rigidbody2D>().position.x<x)
                {
                    temp= ballsInPlay[i];
                    x = ballsInPlay[i].GetComponent<Rigidbody2D>().position.x;
                }
            }
            ball = temp;
        }
        else
        {
            float x = -27f;
            GameObject temp = null;
            foreach(var item in list){
                GameObject check = (GameObject)item;
                if (check.GetComponent<Rigidbody2D>().position.x > x)
                {
                    temp = check;
                    x = check.GetComponent<Rigidbody2D>().position.x;
                }
            }
            ball = temp;
        }
    }
}
