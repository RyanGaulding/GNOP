using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float topBounds = 17.85f;
    public float bottomBounds = -14.24f;
    public Vector2 starttingPosition = new Vector2(21.61402f, 1.135658f);
    private GameObject ball;
    private Vector2 ballPos;

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = (Vector3)starttingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (!ball)
            ball = GameObject.FindGameObjectWithTag("ball");
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
}
