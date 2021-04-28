using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpazBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject temp = collision.gameObject;
        //Put powerup here
        MoveBall();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }

    void MoveBall()
    {
        
    }
}
