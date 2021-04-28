using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastBall : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject temp = collision.gameObject;
        temp.GetComponent<Ball>().increaseSpeed();
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
