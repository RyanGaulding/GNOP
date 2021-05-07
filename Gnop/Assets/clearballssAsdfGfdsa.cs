using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearballssAsdfGfdsa : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject temp = collision.gameObject;
        SpriteRenderer rasdf = temp.GetComponent<SpriteRenderer>();
        Color newColor = rasdf.material.color;
        newColor.a = 0;
        rasdf.material.color = newColor;
        

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
