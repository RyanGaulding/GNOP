using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBalls : MonoBehaviour
{
    //public GameObject myFab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject temp = collision.gameObject;
        for (int i = 0; i < 2; i++)
        {
            GameObject newBall = Instantiate(temp);
            var render = newBall.GetComponent<Renderer>();
            Color color = newBall.GetComponent<Color>();
            color.a = 100;
            render.material.SetColor("_Color", color);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
