using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointRight : MonoBehaviour
{
    private int scoreRight;
    // Start is called before the first frame update
    void Start()
    {
        scoreRight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            scoreRight++;
        }
    }
}
