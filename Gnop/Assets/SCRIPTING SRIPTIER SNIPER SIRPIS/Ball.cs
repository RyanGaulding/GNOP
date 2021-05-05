using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 30;
    public AudioSource hit;
    public GameObject blueOne;

    public void PlayHit()
    {
        hit.Play();
    }


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
    public void increaseSpeed()
    {
        speed = speed * 2;
    }
    private Material currentMat;
   
    public void GhostBall()
    {
        int alphaVal = 0;
        currentMat = gameObject.GetComponent<Renderer>().material;
        Color oldColor = currentMat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, 10);
        currentMat.SetColor("_Color", newColor);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Note: 'col' holds the collision information. If the
        // Ball collided with a racket, then:
        //   col.gameObject is the racket
        //   col.transform.position is the racket's position
        //   col.collider is the racket's collider

        
        // Hit the left Racket?
        PlayHit();
        if (col.gameObject.name == "RacketLeft")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Hit the right Racket?
        if (col.gameObject.name == "RacketRight")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // portals
        if (collision.gameObject.name == "Orange Portal (1)")
        {
            GetComponent<Transform>().position = blueOne.GetComponent<Transform>().position;

        }
    }


    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketHeight)
    {
        // ascii art of the paddle:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    public bool getRight()
    {
        return GetComponent<Rigidbody2D>().velocity.x > 0f;
    }
}
